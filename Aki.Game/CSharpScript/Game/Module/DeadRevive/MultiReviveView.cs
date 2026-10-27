using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005AC6 RID: 23238
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiReviveView : UiTickViewBase
	{
		// Token: 0x0603ADA7 RID: 241063 RVA: 0x00E06F72 File Offset: 0x00E05172
		public MultiReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603ADA8 RID: 241064 RVA: 0x00E06FA4 File Offset: 0x00E051A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickQuitBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickAgainBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickReviveBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickReviveAtLocationBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ADA9 RID: 241065 RVA: 0x00E07204 File Offset: 0x00E05404
		protected override void OnAddEventListener()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				EventSystem.Instance.Add<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
				EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			}
		}

		// Token: 0x0603ADAA RID: 241066 RVA: 0x00E07258 File Offset: 0x00E05458
		protected override void OnRemoveEventListener()
		{
			if (EventSystem.Instance.Has(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept)))
			{
				EventSystem.Instance.Remove(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
			}
			if (EventSystem.Instance.Has(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange)))
			{
				EventSystem.Instance.Remove(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			}
		}

		// Token: 0x0603ADAB RID: 241067 RVA: 0x00E072D8 File Offset: 0x00E054D8
		protected override void OnBeforeShow()
		{
			bool flag = GameModeController.Instance.IsInInstance();
			base.GetButton(1).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(2).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(7).RootUIComp.Get().SetUIActive(!flag);
			if (flag)
			{
				this.UpdateOnlineTeamPlayer();
				this.UpdateOnlineText();
				return;
			}
			base.GetItem(3).SetUIActive(false);
			this.InitRevive();
		}

		// Token: 0x0603ADAC RID: 241068 RVA: 0x00E07364 File Offset: 0x00E05564
		protected override void OnBeforeDestroy()
		{
			this.ResetData();
		}

		// Token: 0x0603ADAD RID: 241069 RVA: 0x00E0736C File Offset: 0x00E0556C
		private void ResetData()
		{
			this.ReviveNumber = -1;
			this.AutoReviveTime = 0;
			this.AutoReviveText = null;
			this.ReviveAtLocationName = "";
			this.ReviveAtLocationCd = "";
			if (this.AutoReviveTimer != null)
			{
				this.AutoReviveTimer.Remove();
				this.AutoReviveTimer = null;
			}
			if (this.PlayerStateItemMap != null)
			{
				this.PlayerStateItemMap.Clear();
			}
		}

		// Token: 0x0603ADAE RID: 241070 RVA: 0x00E073D4 File Offset: 0x00E055D4
		private void InitRevive()
		{
			Revive? reviveConfig = DeadReviveModel.Instance.ReviveConfig;
			if (reviveConfig != null)
			{
				this.ReviveNumber = reviveConfig.Value.ReviveTimes;
			}
			if (this.AutoReviveTimer == null)
			{
				this.AutoReviveTime = 60;
				this.AutoReviveText = base.GetText(8);
				LguiUtil.Instance.SetLocalText(this.AutoReviveText, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveTime));
				this.AutoReviveTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					if (this.AutoReviveTime <= 0)
					{
						ConfirmBoxController.Instance.CloseConfirmBoxView();
						this.OnClickReviveBtn();
						if (this.AutoReviveTimer != null)
						{
							this.AutoReviveTimer.Remove();
							this.AutoReviveTimer = null;
						}
						return;
					}
					this.AutoReviveTime--;
					LguiUtil.Instance.SetLocalText(this.AutoReviveText, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveTime));
				}, 1000f, 1f, null, null, true);
			}
			int num = -1;
			Revive? reviveConfig2 = DeadReviveModel.Instance.ReviveConfig;
			if (reviveConfig2 != null)
			{
				num = reviveConfig2.Value.UseItemId;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
			if (itemCountByConfigId <= 0)
			{
				return;
			}
			base.GetButton(9).RootUIComp.Get().SetUIActive(true);
			UUITexture texture = base.GetTexture(10);
			UUIText text = base.GetText(11);
			BuffItemModel instance = BuffItemModel.Instance;
			base.SetItemIcon(texture, num, null, null);
			this.ReviveAtLocationName = ItemConfig.Instance.GetItemName(num);
			int buffItemTotalCdTime = BuffItemConfig.Instance.GetBuffItemTotalCdTime(num);
			if ((double)buffItemTotalCdTime < TimeUtil.Instance.Minute)
			{
				this.ReviveAtLocationCd = buffItemTotalCdTime.ToString() + TextConfig.Instance.GetTextById("Second");
			}
			else
			{
				this.ReviveAtLocationCd = Math.Floor((double)buffItemTotalCdTime / TimeUtil.Instance.Minute).ToString() + TextConfig.Instance.GetTextById("MinuteText");
				double num2 = (double)buffItemTotalCdTime % TimeUtil.Instance.Minute;
				if (num2 > 0.0)
				{
					this.ReviveAtLocationCd = this.ReviveAtLocationCd + num2.ToString() + TextConfig.Instance.GetTextById("Second");
				}
			}
			if (instance.GetBuffItemRemainCdTime(num) > 0.0)
			{
				LguiUtil.Instance.SetLocalText(text, "ReviveItemCd", Array.Empty<object>());
				(base.GetButton(9).GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(false);
				return;
			}
			text.SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0603ADAF RID: 241071 RVA: 0x00E07620 File Offset: 0x00E05820
		private void OnClickReviveBtn()
		{
			if (this.ReviveNumber == 0)
			{
				ScrollingTipsController.Instance.ShowTipsById("CannotRevive", Array.Empty<object>());
				return;
			}
			this.RequestRevive(false);
		}

		// Token: 0x0603ADB0 RID: 241072 RVA: 0x00E07648 File Offset: 0x00E05848
		private void OnClickReviveAtLocationBtn()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.UsingItemRevive);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				this.ReviveAtLocationName,
				this.ReviveAtLocationCd
			});
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RequestRevive(true);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603ADB1 RID: 241073 RVA: 0x00E076A0 File Offset: 0x00E058A0
		private void RequestRevive(bool useItem)
		{
			DeadReviveController.Instance.ReviveRequest(useItem, delegate(bool result)
			{
				if (result)
				{
					this.ResetData();
				}
			}, null);
		}

		// Token: 0x0603ADB2 RID: 241074 RVA: 0x00E076D0 File Offset: 0x00E058D0
		private void UpdateOnlineTeamPlayer()
		{
			UUIText text = base.GetText(0);
			UUIItem item = base.GetItem(3);
			List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
			bool flag = true;
			foreach (ScenePlayerData scenePlayerData in allScenePlayers)
			{
				if (SceneTeamModel.Instance.GetGroupLivingState(scenePlayerData.GetPlayerId(), ETeamGroupType.Battle) == ETeamLivingState.Alive)
				{
					flag = false;
					break;
				}
			}
			if (allScenePlayers.Count <= 1 || !flag)
			{
				text.SetUIActive(true);
				item.SetUIActive(false);
				return;
			}
			text.SetUIActive(false);
			item.SetUIActive(true);
			UUISprite sprite = base.GetSprite(4);
			UUISprite sprite2 = base.GetSprite(5);
			sprite.SetUIActive(false);
			sprite2.SetUIActive(false);
			int? id = PlayerInfoModel.Instance.GetId();
			foreach (ScenePlayerData scenePlayerData2 in allScenePlayers)
			{
				int playerId = scenePlayerData2.GetPlayerId();
				int num = playerId;
				int? num2 = id;
				if (!(num == num2.GetValueOrDefault() & num2 != null))
				{
					EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(playerId);
					if (!sprite.bIsUIActive)
					{
						sprite.SetUIActive(true);
						this.SetTeamPlayerSprite(continuingChallengeConfirmState.Value, sprite);
						this.PlayerStateItemMap[playerId] = sprite;
					}
					else if (!sprite2.bIsUIActive)
					{
						sprite2.SetUIActive(true);
						this.SetTeamPlayerSprite(continuingChallengeConfirmState.Value, sprite2);
						this.PlayerStateItemMap[playerId] = sprite2;
					}
				}
			}
		}

		// Token: 0x0603ADB3 RID: 241075 RVA: 0x00E07870 File Offset: 0x00E05A70
		private void UpdateOnlineText()
		{
			if (CreatureModel.Instance.IsMyWorld())
			{
				LguiUtil.Instance.SetLocalText(base.GetText(6), "ChallengeAgain", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(6), "SuggestChallengeAgain", Array.Empty<object>());
		}

		// Token: 0x0603ADB4 RID: 241076 RVA: 0x00E078C0 File Offset: 0x00E05AC0
		private void SetTeamPlayerSprite(EContinuingChallenge state, UUISprite playerSprite)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(OnlineDefine.onlineContinuingChallengeIcon[state]);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, playerSprite, false, null, null);
			}
		}

		// Token: 0x0603ADB5 RID: 241077 RVA: 0x00E07900 File Offset: 0x00E05B00
		private void OnClickQuitBtn()
		{
			if (SceneTeamModel.Instance.IsAllDid())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.OnlineQuitInstance);
			Action value = delegate()
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603ADB6 RID: 241078 RVA: 0x00E0796C File Offset: 0x00E05B6C
		private void OnClickAgainBtn()
		{
			if (!SceneTeamModel.Instance.IsAllDid())
			{
				ScrollingTipsController.Instance.ShowTipsById("NeedAllDeadToChallengeAgain", Array.Empty<object>());
				return;
			}
			if (!OnlineModel.Instance.AllowInitiate)
			{
				ScrollingTipsController.Instance.ShowTipsById("CannotInvite", Array.Empty<object>());
				return;
			}
			bool flag = CreatureModel.Instance.IsMyWorld();
			double nextInitiateLeftTime = OnlineModel.Instance.NextInitiateLeftTime;
			if (nextInitiateLeftTime > 0.0)
			{
				if (flag)
				{
					ScrollingTipsController.Instance.ShowTipsById("NextInviteTime", new object[]
					{
						TimeUtil.Instance.GetCoolDown(nextInitiateLeftTime)
					});
					return;
				}
				ScrollingTipsController.Instance.ShowTipsById("NextSuggestTime", new object[]
				{
					TimeUtil.Instance.GetCoolDown(nextInitiateLeftTime)
				});
				return;
			}
			else
			{
				if (OnlineModel.Instance.GetContinuingChallengeConfirmState(PlayerInfoModel.Instance.GetId().Value).GetValueOrDefault() == EContinuingChallenge.Pending)
				{
					OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Dead);
					return;
				}
				if (flag)
				{
					OnlineController.Instance.InviteRechallengeRequest();
					return;
				}
				OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Dead);
				return;
			}
		}

		// Token: 0x0603ADB7 RID: 241079 RVA: 0x00E07A74 File Offset: 0x00E05C74
		private void OnlineTeamPlayerAccept(int playerId, EContinuingChallenge state)
		{
			UUISprite uuisprite;
			this.PlayerStateItemMap.TryGetValue(playerId, out uuisprite);
			if (uuisprite == null)
			{
				return;
			}
			this.SetTeamPlayerSprite(state, uuisprite);
		}

		// Token: 0x0603ADB8 RID: 241080 RVA: 0x00E07A9C File Offset: 0x00E05C9C
		private void OnTeamLivingStateChange(bool b, ETeamGroupType eTeamGroupType, ETeamLivingState arg3, ETeamLivingState arg4)
		{
			this.UpdateOnlineTeamPlayer();
		}

		// Token: 0x0401EB6A RID: 125802
		private const int TIME_SECOND = 1000;

		// Token: 0x0401EB6B RID: 125803
		private const int AUTO_REVIVE_TIME = 60;

		// Token: 0x0401EB6C RID: 125804
		private readonly Dictionary<int, UUISprite> PlayerStateItemMap = new Dictionary<int, UUISprite>();

		// Token: 0x0401EB6D RID: 125805
		private string ReviveAtLocationName = "";

		// Token: 0x0401EB6E RID: 125806
		private string ReviveAtLocationCd = "";

		// Token: 0x0401EB6F RID: 125807
		private int ReviveNumber = -1;

		// Token: 0x0401EB70 RID: 125808
		private int AutoReviveTime;

		// Token: 0x0401EB71 RID: 125809
		[Nullable(2)]
		private TimerHandle AutoReviveTimer;

		// Token: 0x0401EB72 RID: 125810
		[Nullable(2)]
		private UUIText AutoReviveText;

		// Token: 0x0200BD18 RID: 48408
		[NullableContext(0)]
		private class EOnlineInstanceDungeonDeathPanel
		{
			// Token: 0x0403907D RID: 233597
			public const int TextTips = 0;

			// Token: 0x0403907E RID: 233598
			public const int QuitButton = 1;

			// Token: 0x0403907F RID: 233599
			public const int AgainButton = 2;

			// Token: 0x04039080 RID: 233600
			public const int TeamPlayerStateItem = 3;

			// Token: 0x04039081 RID: 233601
			public const int TeamPlayer1Sprite = 4;

			// Token: 0x04039082 RID: 233602
			public const int TeamPlayer2Sprite = 5;

			// Token: 0x04039083 RID: 233603
			public const int TextAgain = 6;

			// Token: 0x04039084 RID: 233604
			public const int ReviveBtn = 7;

			// Token: 0x04039085 RID: 233605
			public const int AutoReviveText = 8;

			// Token: 0x04039086 RID: 233606
			public const int ReviveAtLocationBtn = 9;

			// Token: 0x04039087 RID: 233607
			public const int ReviveAtLocationTexture = 10;

			// Token: 0x04039088 RID: 233608
			public const int ReviveAtLocationText = 11;
		}
	}
}
