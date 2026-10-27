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
	// Token: 0x02005881 RID: 22657
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonVictoryView : CommonResultView
	{
		// Token: 0x06039A92 RID: 236178 RVA: 0x00DB423F File Offset: 0x00DB243F
		public InstanceDungeonVictoryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17008A7D RID: 35453
		// (get) Token: 0x06039A93 RID: 236179 RVA: 0x00DB4254 File Offset: 0x00DB2454
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

		// Token: 0x06039A94 RID: 236180 RVA: 0x00DB4284 File Offset: 0x00DB2484
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

		// Token: 0x06039A95 RID: 236181 RVA: 0x00DB42DA File Offset: 0x00DB24DA
		private List<CommonResultButtonData> CreateInstanceDungeonCommonButtonData()
		{
			List<CommonResultButtonData> list = new List<CommonResultButtonData>(2);
			list[0] = this.CreateFirstButtonData();
			list[1] = this.CreateSecondButtonData();
			return list;
		}

		// Token: 0x06039A96 RID: 236182 RVA: 0x00DB42FC File Offset: 0x00DB24FC
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

		// Token: 0x06039A97 RID: 236183 RVA: 0x00DB4327 File Offset: 0x00DB2527
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

		// Token: 0x06039A98 RID: 236184 RVA: 0x00DB4354 File Offset: 0x00DB2554
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

		// Token: 0x06039A99 RID: 236185 RVA: 0x00DB43D8 File Offset: 0x00DB25D8
		protected override void OnAfterShow()
		{
			this.UpdateView();
		}

		// Token: 0x06039A9A RID: 236186 RVA: 0x00DB43E0 File Offset: 0x00DB25E0
		protected override void OnBeforeDestroy()
		{
			ItemHintModel.Instance.CleanItemRewardList();
			this.PlayerStateItemMap.Clear();
		}

		// Token: 0x06039A9B RID: 236187 RVA: 0x00DB43F7 File Offset: 0x00DB25F7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
		}

		// Token: 0x06039A9C RID: 236188 RVA: 0x00DB4415 File Offset: 0x00DB2615
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
		}

		// Token: 0x06039A9D RID: 236189 RVA: 0x00DB4433 File Offset: 0x00DB2633
		private void UpdateView()
		{
			this.UpdateRewardPreview();
		}

		// Token: 0x06039A9E RID: 236190 RVA: 0x00DB443C File Offset: 0x00DB263C
		private void UpdateRewardPreview()
		{
			this.RewardItemList = InstanceDungeonEntranceModel.Instance.SettleRewardItemList;
			this.RewardLayout.RebuildLayoutByDataNew<TItem>(this.RewardItemList, null);
		}

		// Token: 0x06039A9F RID: 236191 RVA: 0x00DB4474 File Offset: 0x00DB2674
		protected override void SetupButtonFormat()
		{
			List<CommonResultButtonData> dataList = this.CreateInstanceDungeonCommonButtonData();
			base.RefreshButtonList(dataList);
		}

		// Token: 0x06039AA0 RID: 236192 RVA: 0x00DB448F File Offset: 0x00DB268F
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

		// Token: 0x06039AA1 RID: 236193 RVA: 0x00DB44B0 File Offset: 0x00DB26B0
		private void OnClickBtnAgain()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().ContinueWith(delegate(bool _)
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

		// Token: 0x06039AA2 RID: 236194 RVA: 0x00DB45C0 File Offset: 0x00DB27C0
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

		// Token: 0x06039AA3 RID: 236195 RVA: 0x00DB46EC File Offset: 0x00DB28EC
		private void SetTeamPlayerSprite(EContinuingChallenge state, UUISprite playerSprite)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(OnlineDefine.onlineContinuingChallengeIcon[state]);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, playerSprite, false, null, null);
			}
		}

		// Token: 0x06039AA4 RID: 236196 RVA: 0x00DB472C File Offset: 0x00DB292C
		private void OnlineTeamPlayerAccept(int playerId, EContinuingChallenge state)
		{
			UUISprite playerSprite;
			if (!this.PlayerStateItemMap.TryGetValue(playerId, out playerSprite))
			{
				return;
			}
			this.SetTeamPlayerSprite(state, playerSprite);
		}

		// Token: 0x0401E217 RID: 123415
		private int InstanceId;

		// Token: 0x0401E218 RID: 123416
		private readonly Dictionary<int, UUISprite> PlayerStateItemMap = new Dictionary<int, UUISprite>();

		// Token: 0x0401E219 RID: 123417
		[Nullable(2)]
		private TItem[] RewardItemList;

		// Token: 0x0401E21A RID: 123418
		private static readonly FColor ConditionTextColorRed = new FColor(246, 93, 88, byte.MaxValue);

		// Token: 0x0401E21B RID: 123419
		private static readonly FColor ConditionTextColorWhite = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
	}
}
