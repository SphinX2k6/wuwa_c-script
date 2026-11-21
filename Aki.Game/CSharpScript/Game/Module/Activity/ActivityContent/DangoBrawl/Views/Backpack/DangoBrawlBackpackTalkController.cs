using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200579D RID: 22429
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackpackTalkController
	{
		// Token: 0x17006A9C RID: 27292
		// (get) Token: 0x060375C3 RID: 226755 RVA: 0x00F766B0 File Offset: 0x00F748B0
		private static long NowWallMs
		{
			get
			{
				return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			}
		}

		// Token: 0x060375C4 RID: 226756 RVA: 0x00F766CC File Offset: 0x00F748CC
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

		// Token: 0x060375C5 RID: 226757 RVA: 0x00F76844 File Offset: 0x00F74A44
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

		// Token: 0x060375C6 RID: 226758 RVA: 0x00F76918 File Offset: 0x00F74B18
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

		// Token: 0x060375C7 RID: 226759 RVA: 0x00F769F6 File Offset: 0x00F74BF6
		private void OnAnyInput(string _, InputDistributeDefine.EActionType type, InputIdentification __)
		{
			if (type == InputDistributeDefine.EActionType.Press)
			{
				this.LastActiveWallMs = DangoBrawlBackpackTalkController.NowWallMs;
			}
		}

		// Token: 0x060375C8 RID: 226760 RVA: 0x00F76A08 File Offset: 0x00F74C08
		private void OnStartFightStateModify(EDangoBrawlFightState state, EDangoBrawlFightState preState)
		{
			if (state != EDangoBrawlFightState.Matching)
			{
				return;
			}
			this.TryShowTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopTrashTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.Trash, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopTrashTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
		}

		// Token: 0x060375C9 RID: 226761 RVA: 0x00F76A90 File Offset: 0x00F74C90
		private void OnRoundStartEffectsReady()
		{
			if (this.ActData.FightersServerData.GetCostDelta() > 0)
			{
				this.TryShowTalk((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().GetShopCostUpTalkIdListArray() : null, DangoBrawlBackpackTalkController.EBubblePriority.CostUp, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopCostUpTalkSpineAnim : null) ?? string.Empty, ((this.RoleConfig != null) ? this.RoleConfig.GetValueOrDefault().ShopIdleSpineAnim : null) ?? string.Empty);
			}
		}

		// Token: 0x060375CA RID: 226762 RVA: 0x00F76B28 File Offset: 0x00F74D28
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

		// Token: 0x060375CB RID: 226763 RVA: 0x00F76BEF File Offset: 0x00F74DEF
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

		// Token: 0x060375CC RID: 226764 RVA: 0x00F76C1C File Offset: 0x00F74E1C
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

		// Token: 0x060375CD RID: 226765 RVA: 0x00F76CB8 File Offset: 0x00F74EB8
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

		// Token: 0x060375CE RID: 226766 RVA: 0x00F76D9C File Offset: 0x00F74F9C
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

		// Token: 0x060375CF RID: 226767 RVA: 0x00F76E14 File Offset: 0x00F75014
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

		// Token: 0x060375D0 RID: 226768 RVA: 0x00F76EA0 File Offset: 0x00F750A0
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

		// Token: 0x060375D1 RID: 226769 RVA: 0x00F76EE4 File Offset: 0x00F750E4
		private void OnShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			this.OnItemAcquired(configId);
		}

		// Token: 0x060375D2 RID: 226770 RVA: 0x00F76EED File Offset: 0x00F750ED
		private void OnShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			this.OnItemAcquired(configId);
		}

		// Token: 0x0401D3B8 RID: 119736
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D3B9 RID: 119737
		private UUIItem PnlChat;

		// Token: 0x0401D3BA RID: 119738
		private UUIText TxtChat;

		// Token: 0x0401D3BB RID: 119739
		private DangoBrawlRole? RoleConfig;

		// Token: 0x0401D3BC RID: 119740
		private DangoBrawlActivity? ActivityConfig;

		// Token: 0x0401D3BD RID: 119741
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401D3BE RID: 119742
		private int IdleTickId = -1;

		// Token: 0x0401D3BF RID: 119743
		private bool PendingIdleTalk;

		// Token: 0x0401D3C0 RID: 119744
		private long LastActiveWallMs;

		// Token: 0x0401D3C1 RID: 119745
		private long BubbleHideAtWallMs;

		// Token: 0x0401D3C2 RID: 119746
		private DangoBrawlBackpackTalkController.EBubblePriority CurrentPriority;

		// Token: 0x0401D3C3 RID: 119747
		[Nullable(2)]
		private USpineSkeletonAnimationComponent RoleSpine;

		// Token: 0x0401D3C4 RID: 119748
		[Nullable(2)]
		private UTrackEntry TalkEntry;

		// Token: 0x0200B3DF RID: 46047
		[NullableContext(0)]
		private enum EBubblePriority
		{
			// Token: 0x040379FC RID: 227836
			None,
			// Token: 0x040379FD RID: 227837
			Tips,
			// Token: 0x040379FE RID: 227838
			Trash,
			// Token: 0x040379FF RID: 227839
			Weapon = 2,
			// Token: 0x04037A00 RID: 227840
			CostUp
		}
	}
}
