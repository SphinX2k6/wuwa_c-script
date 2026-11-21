using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004859 RID: 18521
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonVictoryView : CommonResultView
	{
		// Token: 0x0602E9B5 RID: 190901 RVA: 0x00D03153 File Offset: 0x00D01353
		public InstanceDungeonVictoryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17005E49 RID: 24137
		// (get) Token: 0x0602E9B6 RID: 190902 RVA: 0x00D03168 File Offset: 0x00D01368
		private InstanceDungeon? InstanceConfig
		{
			get
			{
				if (this.InstanceId == 0)
				{
					return null;
				}
				return InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			}
		}

		// Token: 0x0602E9B7 RID: 190903 RVA: 0x00D03198 File Offset: 0x00D01398
		protected override void OnStart()
		{
			this.InstanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			base.OnStart();
			if (UiManager.Instance.IsViewShow(EUiViewName.ReviveView))
			{
				UiManager.Instance.CloseView(EUiViewName.ReviveView, null);
			}
			if (GameModeModel.Instance.IsMulti)
			{
				this.UpdateOnlineTeamPlayer();
			}
		}

		// Token: 0x0602E9B8 RID: 190904 RVA: 0x00D031EE File Offset: 0x00D013EE
		private List<CommonResultButtonData> CreateInstanceDungeonCommonButtonData()
		{
			List<CommonResultButtonData> list = new List<CommonResultButtonData>(2);
			list[0] = this.CreateFirstButtonData();
			list[1] = this.CreateSecondButtonData();
			return list;
		}

		// Token: 0x0602E9B9 RID: 190905 RVA: 0x00D03210 File Offset: 0x00D01410
		private CommonResultButtonData CreateFirstButtonData()
		{
			CommonResultButtonData commonResultButtonData = new CommonResultButtonData();
			commonResultButtonData.SetRefreshCallBack(delegate(CommonResultButton button)
			{
				button.SetBtnText("ButtonTextExit", Array.Empty<object>());
				int autoLeaveTime = this.InstanceConfig.Value.AutoLeaveTime;
				button.SetFloatTextWithTimer(autoLeaveTime, true, "InstanceDungeonLeftTimeToAutoLeave");
			});
			commonResultButtonData.SetClickCallBack(new Action(this.OnClickBtnLeave));
			return commonResultButtonData;
		}

		// Token: 0x0602E9BA RID: 190906 RVA: 0x00D0323B File Offset: 0x00D0143B
		private CommonResultButtonData CreateSecondButtonData()
		{
			CommonResultButtonData commonResultButtonData = new CommonResultButtonData();
			commonResultButtonData.SetRefreshCallBack(delegate(CommonResultButton button)
			{
				button.SetBtnText("ButtonTextRetry", Array.Empty<object>());
				if (GameModeModel.Instance.IsMulti)
				{
					if (CreatureModel.Instance.IsMyWorld())
					{
						button.SetBtnText("ContinueChallenge", Array.Empty<object>());
					}
					else
					{
						button.SetBtnText("SuggestContinueChallenge", Array.Empty<object>());
					}
				}
				this.UpdateButtonPowerTips(button);
			});
			commonResultButtonData.SetClickCallBack(new Action(this.OnClickBtnAgain));
			return commonResultButtonData;
		}

		// Token: 0x0602E9BB RID: 190907 RVA: 0x00D03268 File Offset: 0x00D01468
		private void UpdateButtonPowerTips(CommonResultButton button)
		{
			int? instancePowerCost = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(this.InstanceId);
			bool flag = !(instancePowerCost > 0);
			if (flag)
			{
				return;
			}
			int powerCount = PowerModel.Instance.PowerCount;
			button.SetTipsItem(5, powerCount.ToString());
			int num = powerCount;
			int? num2 = instancePowerCost;
			if (num >= num2.GetValueOrDefault() & num2 != null)
			{
				button.SetTipsItemTextColor(InstanceDungeonVictoryView.ConditionTextColorWhite);
				return;
			}
			button.SetTipsItemTextColor(InstanceDungeonVictoryView.ConditionTextColorRed);
		}

		// Token: 0x0602E9BC RID: 190908 RVA: 0x00D032EC File Offset: 0x00D014EC
		protected override void OnAfterShow()
		{
			this.UpdateView();
		}

		// Token: 0x0602E9BD RID: 190909 RVA: 0x00D032F4 File Offset: 0x00D014F4
		protected override void OnBeforeDestroy()
		{
			ItemHintModel.Instance.CleanItemRewardList();
			this.PlayerStateItemMap.Clear();
		}

		// Token: 0x0602E9BE RID: 190910 RVA: 0x00D0330B File Offset: 0x00D0150B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
		}

		// Token: 0x0602E9BF RID: 190911 RVA: 0x00D03329 File Offset: 0x00D01529
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
		}

		// Token: 0x0602E9C0 RID: 190912 RVA: 0x00D03347 File Offset: 0x00D01547
		private void UpdateView()
		{
			this.UpdateRewardPreview();
		}

		// Token: 0x0602E9C1 RID: 190913 RVA: 0x00D03350 File Offset: 0x00D01550
		private void UpdateRewardPreview()
		{
			this.RewardItemList = InstanceDungeonEntranceModel.Instance.SettleRewardItemList;
			this.RewardLayout.RebuildLayoutByDataNew<TItem>(this.RewardItemList, null);
		}

		// Token: 0x0602E9C2 RID: 190914 RVA: 0x00D03388 File Offset: 0x00D01588
		protected override void SetupButtonFormat()
		{
			List<CommonResultButtonData> dataList = this.CreateInstanceDungeonCommonButtonData();
			base.RefreshButtonList(dataList);
		}

		// Token: 0x0602E9C3 RID: 190915 RVA: 0x00D033A3 File Offset: 0x00D015A3
		private void OnClickBtnLeave()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
			{
				if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x0602E9C4 RID: 190916 RVA: 0x00D033C4 File Offset: 0x00D015C4
		private void OnClickBtnAgain()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).ContinueWith(delegate(bool _)
				{
					if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
					{
						base.CloseMe(null);
					}
				});
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
					OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Settle);
					return;
				}
				if (flag)
				{
					OnlineController.Instance.InviteRechallengeRequest();
					return;
				}
				OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Settle);
				return;
			}
		}

		// Token: 0x0602E9C5 RID: 190917 RVA: 0x00D034D8 File Offset: 0x00D016D8
		private void UpdateOnlineTeamPlayer()
		{
			List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
			if (allScenePlayers.Count <= 1)
			{
				base.GetItem(5).SetUIActive(false);
				return;
			}
			base.GetItem(5).SetUIActive(true);
			UUISprite sprite = base.GetSprite(6);
			UUISprite sprite2 = base.GetSprite(7);
			sprite.SetUIActive(false);
			sprite2.SetUIActive(false);
			int? id = PlayerInfoModel.Instance.GetId();
			foreach (ScenePlayerData scenePlayerData in allScenePlayers)
			{
				int playerId = scenePlayerData.GetPlayerId();
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

		// Token: 0x0602E9C6 RID: 190918 RVA: 0x00D03604 File Offset: 0x00D01804
		private void SetTeamPlayerSprite(EContinuingChallenge state, UUISprite playerSprite)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(OnlineDefine.onlineContinuingChallengeIcon[state]);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, playerSprite, false, null, null);
			}
		}

		// Token: 0x0602E9C7 RID: 190919 RVA: 0x00D03644 File Offset: 0x00D01844
		private void OnlineTeamPlayerAccept(int playerId, EContinuingChallenge state)
		{
			UUISprite playerSprite;
			if (!this.PlayerStateItemMap.TryGetValue(playerId, out playerSprite))
			{
				return;
			}
			this.SetTeamPlayerSprite(state, playerSprite);
		}

		// Token: 0x04018CB4 RID: 101556
		private int InstanceId;

		// Token: 0x04018CB5 RID: 101557
		private readonly Dictionary<int, UUISprite> PlayerStateItemMap = new Dictionary<int, UUISprite>();

		// Token: 0x04018CB6 RID: 101558
		[Nullable(2)]
		private TItem[] RewardItemList;

		// Token: 0x04018CB7 RID: 101559
		private static readonly FColor ConditionTextColorRed = new FColor(246, 93, 88, byte.MaxValue);

		// Token: 0x04018CB8 RID: 101560
		private static readonly FColor ConditionTextColorWhite = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
	}
}
