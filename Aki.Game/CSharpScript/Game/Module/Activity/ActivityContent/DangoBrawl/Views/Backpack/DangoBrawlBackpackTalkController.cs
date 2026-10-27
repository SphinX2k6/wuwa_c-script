using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200684D RID: 26701
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackTalkController
	{
		// Token: 0x1700975B RID: 38747
		// (get) Token: 0x06042A6E RID: 273006 RVA: 0x01035188 File Offset: 0x01033388
		private static long NowWallMs
		{
			get
			{
				return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			}
		}

		// Token: 0x06042A6F RID: 273007 RVA: 0x010351A4 File Offset: 0x010333A4
		public void Init(ActivityDangoBrawlData actData, UUIItem pnlChat, UUIText txtChat, int roleId, [Nullable(2)] UiSequencePlayer sequencePlayer, [Nullable(2)] USpineSkeletonAnimationComponent roleSpine)
		{
			if (roleId <= 0)
			{
				return;
			}
			this.ActData = actData;
			this.PnlChat = pnlChat;
			this.TxtChat = txtChat;
			this.SequencePlayer = sequencePlayer;
			this.RoleSpine = roleSpine;
			this.RoleConfig = DangoBrawlConfig.Instance.GetRoleConfigById(roleId);
			this.ActivityConfig = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActData.Id);
			string text = (this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null;
			if (this.RoleSpine != null && this.RoleSpine.IsValid() && !string.IsNullOrEmpty(text))
			{
				this.RoleSpine.SetAnimation(0, text, true);
			}
			this.LastActiveWallMs = DangoBrawlBackpackTalkController.NowWallMs;
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnIdleTick), "DangoBrawlShopIdleTalk", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.IdleTickId = ((ticker != null) ? ticker.Id : -1);
			EventSystem.Instance.Add(EEventName.OnDangoBrawlFightStateModify, new Action<EDangoBrawlFightState, EDangoBrawlFightState>(this.OnStartFightStateModify));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlRoundStartEffectsReady, new Action(this.OnRoundStartEffectsReady));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopComposed));
			InputDistributeController.Instance.BindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnAnyInput));
		}

		// Token: 0x06042A70 RID: 273008 RVA: 0x0103531C File Offset: 0x0103351C
		public void Destroy()
		{
			TickSystem.Instance.Remove(this.IdleTickId);
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFightStateModify, new Action<EDangoBrawlFightState, EDangoBrawlFightState>(this.OnStartFightStateModify));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlRoundStartEffectsReady, new Action(this.OnRoundStartEffectsReady));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopComposed));
			InputDistributeController.Instance.UnBindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnAnyInput));
			this.BubbleHideAtWallMs = 0L;
			this.SequencePlayer = null;
			this.CurrentPriority = DangoBrawlBackpackTalkController.EBubblePriority.None;
			this.PendingIdleTalk = false;
			this.RoleSpine = null;
			this.TalkEntry = null;
		}

		// Token: 0x06042A71 RID: 273009 RVA: 0x010353F0 File Offset: 0x010335F0
		private void OnIdleTick(float deltaMs)
		{
			long nowWallMs = DangoBrawlBackpackTalkController.NowWallMs;
			if (this.BubbleHideAtWallMs > 0L && nowWallMs >= this.BubbleHideAtWallMs)
			{
				this.BubbleHideAtWallMs = 0L;
				this.HideBubble();
			}
			if (this.ActivityConfig == null)
			{
				return;
			}
			if (nowWallMs - this.LastActiveWallMs < (long)this.ActivityConfig.Value.ShopTipsTalkGapTime)
			{
				return;
			}
			this.LastActiveWallMs = nowWallMs;
			this.TryShowTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopTipsTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.Tips, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopTipsTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
		}

		// Token: 0x06042A72 RID: 273010 RVA: 0x010354CE File Offset: 0x010336CE
		private void OnAnyInput(string _, InputDistributeDefine.EActionType type, InputIdentification __)
		{
			if (type == InputDistributeDefine.EActionType.Press)
			{
				this.LastActiveWallMs = DangoBrawlBackpackTalkController.NowWallMs;
			}
		}

		// Token: 0x06042A73 RID: 273011 RVA: 0x010354E0 File Offset: 0x010336E0
		private void OnStartFightStateModify(EDangoBrawlFightState state, EDangoBrawlFightState preState)
		{
			if (state != EDangoBrawlFightState.Matching)
			{
				return;
			}
			this.TryShowTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopTrashTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.Trash, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopTrashTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
		}

		// Token: 0x06042A74 RID: 273012 RVA: 0x01035568 File Offset: 0x01033768
		private void OnRoundStartEffectsReady()
		{
			if (this.ActData.FightersServerData.GetCostDelta() > 0)
			{
				this.TryShowTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopCostUpTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.CostUp, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopCostUpTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
			}
		}

		// Token: 0x06042A75 RID: 273013 RVA: 0x01035600 File Offset: 0x01033800
		private void OnItemAcquired(int configId)
		{
			DangoBrawlItem? config = ConfigDangoBrawlItemById.GetConfig(configId, true);
			if (config == null || this.ActivityConfig == null)
			{
				return;
			}
			if (config.Value.Quality < this.ActivityConfig.Value.ShopWeaponTalkQuality)
			{
				return;
			}
			this.TryShowTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopWeaponTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.Trash, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopWeaponTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
		}

		// Token: 0x06042A76 RID: 273014 RVA: 0x010356C7 File Offset: 0x010338C7
		private void TryShowTalk([Nullable(2)] int[] talkIdListStr, DangoBrawlBackpackTalkController.EBubblePriority priority, string animName = "", string nextLoopAnimName = "")
		{
			if (priority >= this.CurrentPriority)
			{
				if (priority > DangoBrawlBackpackTalkController.EBubblePriority.Tips)
				{
					this.PendingIdleTalk = false;
				}
				this.ShowRandomTalk(talkIdListStr, priority, animName, nextLoopAnimName);
				return;
			}
			if (priority == DangoBrawlBackpackTalkController.EBubblePriority.Tips)
			{
				this.PendingIdleTalk = true;
			}
		}

		// Token: 0x06042A77 RID: 273015 RVA: 0x010356F4 File Offset: 0x010338F4
		private void OnBubbleHidden()
		{
			this.CurrentPriority = DangoBrawlBackpackTalkController.EBubblePriority.None;
			if (!this.PendingIdleTalk)
			{
				return;
			}
			this.PendingIdleTalk = false;
			this.ShowRandomTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopTipsTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.Tips, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopTipsTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
		}

		// Token: 0x06042A78 RID: 273016 RVA: 0x01035790 File Offset: 0x01033990
		private unsafe void ShowRandomTalk([Nullable(2)] int[] talkIdListStr, DangoBrawlBackpackTalkController.EBubblePriority priority, string animName = "", string nextLoopAnimName = "")
		{
			if (talkIdListStr == null || talkIdListStr.Length == 0)
			{
				return;
			}
			int randomItem = MathUtils.Instance.GetRandomItem<int>(talkIdListStr);
			DangoTrashTalk? config = ConfigDangoTrashTalkById.GetConfig(randomItem, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				string message = "[ShopTalk] ConfigDangoTrashTalk 不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("talkId", randomItem);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("priority", priority);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (!string.IsNullOrEmpty(config.Value.AudioEvent))
			{
				AudioSystem.Instance.PostEvent(config.Value.AudioEvent);
			}
			this.ShowBubble(config.Value.Textkey, priority);
			this.PlayTalkSpineAnim(animName, nextLoopAnimName);
		}

		// Token: 0x06042A79 RID: 273017 RVA: 0x01035874 File Offset: 0x01033A74
		private void ShowBubble(string textkey, DangoBrawlBackpackTalkController.EBubblePriority priority)
		{
			this.CurrentPriority = priority;
			LguiUtil.Instance.SetLocalTextNew(this.TxtChat, textkey, Array.Empty<object>());
			this.PnlChat.SetUIActive(true);
			this.BubbleHideAtWallMs = 0L;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequenceAsync("BubbleIn", new CustomPromise<bool>(), false, false, null).ContinueWith(delegate()
			{
				this.BubbleHideAtWallMs = DangoBrawlBackpackTalkController.NowWallMs + 5000L;
			});
		}

		// Token: 0x06042A7A RID: 273018 RVA: 0x010358EC File Offset: 0x01033AEC
		private void PlayTalkSpineAnim(string animName, string nextLoopName)
		{
			if (this.RoleSpine == null || !this.RoleSpine.IsValid() || string.IsNullOrEmpty(animName))
			{
				return;
			}
			this.TalkEntry = this.RoleSpine.SetAnimation(0, animName, false);
			UTrackEntry talkEntry = this.TalkEntry;
			if (talkEntry != null)
			{
				talkEntry.SetMixDuration(0.3f);
			}
			UTrackEntry talkEntry2 = this.TalkEntry;
			if (talkEntry2 == null)
			{
				return;
			}
			talkEntry2.AnimationComplete.Add(delegate(UTrackEntry e)
			{
				if (e != this.TalkEntry)
				{
					return;
				}
				if (!string.IsNullOrEmpty(nextLoopName))
				{
					USpineSkeletonAnimationComponent roleSpine = this.RoleSpine;
					UTrackEntry utrackEntry = (roleSpine != null) ? roleSpine.SetAnimation(0, nextLoopName, true) : null;
					if (utrackEntry != null)
					{
						utrackEntry.SetMixDuration(0.3f);
					}
				}
				this.TalkEntry = null;
			});
		}

		// Token: 0x06042A7B RID: 273019 RVA: 0x01035978 File Offset: 0x01033B78
		private void HideBubble()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequenceAsync("BubbleOut", new CustomPromise<bool>(), false, false, null).ContinueWith(delegate()
			{
				this.PnlChat.SetUIActive(false);
				this.OnBubbleHidden();
			});
		}

		// Token: 0x06042A7C RID: 273020 RVA: 0x010359BC File Offset: 0x01033BBC
		private void OnShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			this.OnItemAcquired(configId);
		}

		// Token: 0x06042A7D RID: 273021 RVA: 0x010359C5 File Offset: 0x01033BC5
		private void OnShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			this.OnItemAcquired(configId);
		}

		// Token: 0x04022B5B RID: 142171
		private ActivityDangoBrawlData ActData;

		// Token: 0x04022B5C RID: 142172
		private UUIItem PnlChat;

		// Token: 0x04022B5D RID: 142173
		private UUIText TxtChat;

		// Token: 0x04022B5E RID: 142174
		private DangoBrawlRole? RoleConfig;

		// Token: 0x04022B5F RID: 142175
		private DangoBrawlActivity? ActivityConfig;

		// Token: 0x04022B60 RID: 142176
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04022B61 RID: 142177
		private int IdleTickId = -1;

		// Token: 0x04022B62 RID: 142178
		private bool PendingIdleTalk;

		// Token: 0x04022B63 RID: 142179
		private long LastActiveWallMs;

		// Token: 0x04022B64 RID: 142180
		private long BubbleHideAtWallMs;

		// Token: 0x04022B65 RID: 142181
		private DangoBrawlBackpackTalkController.EBubblePriority CurrentPriority;

		// Token: 0x04022B66 RID: 142182
		[Nullable(2)]
		private USpineSkeletonAnimationComponent RoleSpine;

		// Token: 0x04022B67 RID: 142183
		[Nullable(2)]
		private UTrackEntry TalkEntry;

		// Token: 0x0200CA14 RID: 51732
		[NullableContext(0)]
		private enum EBubblePriority
		{
			// Token: 0x0403D115 RID: 250133
			None,
			// Token: 0x0403D116 RID: 250134
			Tips,
			// Token: 0x0403D117 RID: 250135
			Trash,
			// Token: 0x0403D118 RID: 250136
			Weapon = 2,
			// Token: 0x0403D119 RID: 250137
			CostUp
		}
	}
}
