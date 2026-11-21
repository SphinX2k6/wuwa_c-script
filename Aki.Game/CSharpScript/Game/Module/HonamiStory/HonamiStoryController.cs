using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x020048FF RID: 18687
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryController : ActivityControllerBase
	{
		// Token: 0x0602EEA6 RID: 192166 RVA: 0x00D175A1 File Offset: 0x00D157A1
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.HonamiStoryUnlockTipView, null, null);
		}

		// Token: 0x0602EEA7 RID: 192167 RVA: 0x00D175B4 File Offset: 0x00D157B4
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0602EEA8 RID: 192168 RVA: 0x00D175B6 File Offset: 0x00D157B6
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityHonamiStoryGuide";
		}

		// Token: 0x0602EEA9 RID: 192169 RVA: 0x00D175BD File Offset: 0x00D157BD
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new HonamiStoryActivityView();
		}

		// Token: 0x0602EEAA RID: 192170 RVA: 0x00D175C4 File Offset: 0x00D157C4
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			HonamiStoryActivityData honamiStoryActivityData = new HonamiStoryActivityData();
			HonamiStoryModel.Instance.SetActivityData(honamiStoryActivityData);
			return honamiStoryActivityData;
		}

		// Token: 0x0602EEAB RID: 192171 RVA: 0x00D175E3 File Offset: 0x00D157E3
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0602EEAC RID: 192172 RVA: 0x00D175EC File Offset: 0x00D157EC
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
			EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnEnterDungeon));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
		}

		// Token: 0x0602EEAD RID: 192173 RVA: 0x00D17688 File Offset: 0x00D15888
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
			EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnEnterDungeon));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
		}

		// Token: 0x0602EEAE RID: 192174 RVA: 0x00D17724 File Offset: 0x00D15924
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.HonamiStoryBagInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryBagInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryInstInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryInstInfoNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStorySafeLeaveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStorySafeLeaveNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryMascotInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryMascotInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryAreaInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryAreaInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryResidentTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryPermanentTaskInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryLimitTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryLimitTaskInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryScoreRewardInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryScoreRewardInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryItemCollectionInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryItemCollectionInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryAreaTaskInfoRefreshNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryAreaTaskInfoRefreshNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryAreaTaskInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryAreaTaskInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryRoleUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryInstSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryInstSettleNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryPollutionUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryPollutionUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryBagSizeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryBagSizeUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryAddWeaponNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryAddWeaponNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryInstTopTowerSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryInstTopTowerSettleNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStorySetFormationNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStorySetFormationNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryTalentInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryTalentInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryTotalRevenueNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryTotalRevenueNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryLifeSupportNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryLifeSupportNotify));
			Net.Instance.Register(ENotifyMessageId.HonamiStoryTopInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnHonamiStoryTopInfoNotify));
		}

		// Token: 0x0602EEAF RID: 192175 RVA: 0x00D1799C File Offset: 0x00D15B9C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryBagInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryInstInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStorySafeLeaveNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryInstSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryMascotInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryAreaInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryResidentTaskInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryLimitTaskInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryScoreRewardInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryItemCollectionInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryAreaTaskInfoRefreshNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryAreaTaskInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryRoleUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryPollutionUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryBagSizeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryAddWeaponNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryInstTopTowerSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStorySetFormationNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryTalentInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryTotalRevenueNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HonamiStoryLifeSupportNotify);
		}

		// Token: 0x0602EEB0 RID: 192176 RVA: 0x00D17AFC File Offset: 0x00D15CFC
		private void ActivityInfoRequest(EFunctionType id, bool isOpen)
		{
			if (id != EFunctionType.HonamiStoryMainQuestFuncId)
			{
				return;
			}
			if (!isOpen)
			{
				return;
			}
			HonamiStoryActivityInfoRequest honamiStoryActivityInfoRequest = HonamiStoryActivityInfoRequest.Create();
			IEnumerable<HonamiStoryActivity> allActivityConfig = HonamiStoryConfig.Instance.GetAllActivityConfig();
			int actId = 0;
			foreach (HonamiStoryActivity honamiStoryActivity in allActivityConfig)
			{
				actId = honamiStoryActivity.ActivityId;
			}
			if (actId == 0)
			{
				return;
			}
			honamiStoryActivityInfoRequest.ActivityId = actId;
			Net.Instance.Call(ERequestMessageId.HonamiStoryActivityInfoRequest, honamiStoryActivityInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryActivityInfoResponse honamiStoryActivityInfoResponse = (HonamiStoryActivityInfoResponse)msg;
				if (honamiStoryActivityInfoResponse == null || honamiStoryActivityInfoResponse.HonamiStoryActivityInfo == null)
				{
					return;
				}
				HonamiStoryModel.Instance.InitActivityInfo(actId, honamiStoryActivityInfoResponse.HonamiStoryActivityInfo);
			}, 0);
		}

		// Token: 0x0602EEB1 RID: 192177 RVA: 0x00D17BA8 File Offset: 0x00D15DA8
		public void TryHonamiStoryInstLeave(bool showSafeLeaveUpdate = false)
		{
			HonamiStoryLeaveTipParams honamiStoryLeaveTipParams = new HonamiStoryLeaveTipParams();
			honamiStoryLeaveTipParams.LeaveType = (HonamiStoryModel.Instance.CanSafeLeave ? EHonamiStoryLeaveType.SafeLeave : EHonamiStoryLeaveType.DangerLeave);
			honamiStoryLeaveTipParams.ShowSafeLeaveUpdate = showSafeLeaveUpdate;
			honamiStoryLeaveTipParams.ConfirmCallback = delegate()
			{
				HonamiStoryInstLeaveRequest message = HonamiStoryInstLeaveRequest.Create();
				Net.Instance.Call(ERequestMessageId.HonamiStoryInstLeaveRequest, message, delegate(IMessage _, Net.CallbackStatus __)
				{
				}, 0);
			};
			HonamiStoryLeaveTipParams param = honamiStoryLeaveTipParams;
			UiManager.Instance.OpenView(EUiViewName.HonamiStoryLeaveTip, param, null);
		}

		// Token: 0x0602EEB2 RID: 192178 RVA: 0x00D17C10 File Offset: 0x00D15E10
		[NullableContext(0)]
		public UniTask<bool> OpenHonamiStoryBag()
		{
			HonamiStoryController.<OpenHonamiStoryBag>d__12 <OpenHonamiStoryBag>d__;
			<OpenHonamiStoryBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenHonamiStoryBag>d__.<>1__state = -1;
			<OpenHonamiStoryBag>d__.<>t__builder.Start<HonamiStoryController.<OpenHonamiStoryBag>d__12>(ref <OpenHonamiStoryBag>d__);
			return <OpenHonamiStoryBag>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEB3 RID: 192179 RVA: 0x00D17C4C File Offset: 0x00D15E4C
		public void SetHonamiStoryLoadingInfoByResult(bool isSuccess)
		{
			EHonamiStoryLoadingTimingType honamiStoryLoadingInfoByTimingOnly = isSuccess ? EHonamiStoryLoadingTimingType.SuccessLeave : EHonamiStoryLoadingTimingType.FailLeave;
			this.SetHonamiStoryLoadingInfoByTimingOnly(honamiStoryLoadingInfoByTimingOnly);
		}

		// Token: 0x0602EEB4 RID: 192180 RVA: 0x00D17C68 File Offset: 0x00D15E68
		public void SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType timing)
		{
			HonamiStoryLoadingDataImpl gamePlayLoadingData = new HonamiStoryLoadingDataImpl
			{
				Timing = new int?((int)timing)
			};
			HonamiStoryModel.Instance.SetGamePlayLoadingData(gamePlayLoadingData);
		}

		// Token: 0x0602EEB5 RID: 192181 RVA: 0x00D17C94 File Offset: 0x00D15E94
		public void SetHonamiStoryLoadingInfoByBtId(int btId)
		{
			HonamiStoryLoadingDataImpl gamePlayLoadingData = new HonamiStoryLoadingDataImpl
			{
				Timing = new int?(2),
				BtId = new int?(btId)
			};
			HonamiStoryModel.Instance.SetGamePlayLoadingData(gamePlayLoadingData);
		}

		// Token: 0x0602EEB6 RID: 192182 RVA: 0x00D17CCC File Offset: 0x00D15ECC
		[NullableContext(2)]
		public void OnHonamiStoryInstInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryInstInfoNotify honamiStoryInstInfoNotify = (HonamiStoryInstInfoNotify)msg;
			HonamiStoryModel.Instance.SetIsLastPickUpViewDirty(false);
			HonamiStoryModel.Instance.InitBackPackInfoList(honamiStoryInstInfoNotify.HonamiStoryBagInfos);
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
			this.UpdateHonamiStorySafeLeave(honamiStoryInstInfoNotify.CanSafeLeave, false);
			int dangerLevelId = honamiStoryInstInfoNotify.DangerLevelId;
			if (dangerLevelId > 0)
			{
				HonamiStoryDangerLevel? config = ConfigHonamiStoryDangerLevelById.GetConfig(dangerLevelId, true);
				if (config != null)
				{
					HonamiStoryModel.Instance.MonsterBaseEnhanceLevel = config.Value.MonsterEnhanceLevel;
					HonamiStoryModel.Instance.DangerLevel = config.Value.Level;
				}
				HonamiStoryModel.Instance.PollutionLevel = honamiStoryInstInfoNotify.PollutionLevel;
				HonamiStoryModel.Instance.PollutionStarTime = (float)MathUtils.Instance.LongToNumber(honamiStoryInstInfoNotify.PollutionStartTime);
				Dictionary<int, IHonamiStoryPollution> dictionary = HonamiStoryModel.Instance.PollutionLevelMap;
				if (dictionary != null)
				{
					if (dictionary != null)
					{
						dictionary.Clear();
					}
				}
				else
				{
					dictionary = new Dictionary<int, IHonamiStoryPollution>();
					HonamiStoryModel.Instance.PollutionLevelMap = dictionary;
				}
				int pollutionGroup = honamiStoryInstInfoNotify.PollutionGroup;
				HonamiStoryPollutionStage? config2 = ConfigHonamiStoryPollutionStageById.GetConfig(pollutionGroup, true);
				if (config2 != null)
				{
					HonamiStoryModel.Instance.PollutionWarningLevel = config2.Value.WarningLevel;
					HonamiStoryModel.Instance.PollutionDangerLevel = config2.Value.DangerLevel;
				}
				IReadOnlyList<HonamiStoryPollution> configList = ConfigHonamiStoryPollutionByActivityId.GetConfigList(honamiStoryInstInfoNotify.ActivityId, true);
				if (configList != null)
				{
					List<IHonamiStoryPollution> list = new List<IHonamiStoryPollution>();
					foreach (HonamiStoryPollution honamiStoryPollution in configList)
					{
						if (honamiStoryPollution.Group == pollutionGroup)
						{
							list.Add(new HonamiStoryPollution
							{
								PollutionLevel = honamiStoryPollution.Level,
								PersistMilliseconds = honamiStoryPollution.PersistSecond * 1000,
								MonsterEnhanceLevel = honamiStoryPollution.MonsterEnhanceLevel
							});
						}
					}
					list.Sort((IHonamiStoryPollution a, IHonamiStoryPollution b) => a.PollutionLevel - b.PollutionLevel);
					IHonamiStoryPollution honamiStoryPollution2 = null;
					foreach (IHonamiStoryPollution honamiStoryPollution3 in list)
					{
						if (honamiStoryPollution2 != null)
						{
							honamiStoryPollution3.MonsterEnhanceLevel += honamiStoryPollution2.MonsterEnhanceLevel;
						}
						dictionary[honamiStoryPollution3.PollutionLevel] = honamiStoryPollution3;
						honamiStoryPollution2 = honamiStoryPollution3;
					}
					HonamiStoryModel.Instance.PollutionMaxLevel = list[list.Count - 1].PollutionLevel;
				}
			}
			HonamiStoryModel.Instance.MonsterLevelSafeOffset = ConfigCommonParamById.GetIntConfig("HonamiStorySafeLevelOffset").GetValueOrDefault();
			HonamiStoryModel.Instance.MonsterLevelDangerOffset = -ConfigCommonParamById.GetIntConfig("HonamiStoryDangerLevelOffset").GetValueOrDefault();
			HonamiStoryModel.Instance.CurAreaId = honamiStoryInstInfoNotify.HonamiStoryAreaId;
			EventSystem.Instance.Emit(EEventName.OnHonamiStoryInstInfoUpdate);
		}

		// Token: 0x0602EEB7 RID: 192183 RVA: 0x00D17FB0 File Offset: 0x00D161B0
		[NullableContext(2)]
		private void OnHonamiStorySafeLeaveNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStorySafeLeaveNotify honamiStorySafeLeaveNotify = (HonamiStorySafeLeaveNotify)msg;
			this.UpdateHonamiStorySafeLeave(honamiStorySafeLeaveNotify.CanSafeLeave, true);
		}

		// Token: 0x0602EEB8 RID: 192184 RVA: 0x00D17FD1 File Offset: 0x00D161D1
		private void UpdateHonamiStorySafeLeave(bool canSafeLeave, bool showLeave)
		{
			if (HonamiStoryModel.Instance.CanSafeLeave == canSafeLeave)
			{
				if (canSafeLeave && showLeave)
				{
					this.TryHonamiStoryInstLeave(false);
				}
				return;
			}
			HonamiStoryModel.Instance.CanSafeLeave = canSafeLeave;
			if (!canSafeLeave)
			{
				return;
			}
			if (showLeave)
			{
				this.TryHonamiStoryInstLeave(true);
				return;
			}
			this.ShowSafeLeaveUpdate();
		}

		// Token: 0x0602EEB9 RID: 192185 RVA: 0x00D1800D File Offset: 0x00D1620D
		public void ShowSafeLeaveUpdate()
		{
			if (GameModeModel.Instance.WorldDoneAndLoadingClosed)
			{
				UiManager.Instance.OpenView(EUiViewName.HonamiStorySafeLeaveUpdateView, null, null);
				EventSystem.Instance.Emit(EEventName.OnHonamiStoryLeaveButtonUpdate);
				return;
			}
			HonamiStoryModel.Instance.CacheShowSafeLeaveUpdate = true;
		}

		// Token: 0x0602EEBA RID: 192186 RVA: 0x00D18048 File Offset: 0x00D16248
		[NullableContext(2)]
		private void OnHonamiStoryPollutionUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryPollutionUpdateNotify honamiStoryPollutionUpdateNotify = (HonamiStoryPollutionUpdateNotify)msg;
			int pollutionLevel = HonamiStoryModel.Instance.PollutionLevel;
			int pollutionLevel2 = honamiStoryPollutionUpdateNotify.PollutionLevel;
			long num = MathUtils.Instance.LongToNumber(honamiStoryPollutionUpdateNotify.PollutionStartTime);
			HonamiStoryModel.Instance.PollutionLevel = pollutionLevel2;
			HonamiStoryModel.Instance.PollutionStarTime = (float)num;
			Dictionary<int, IHonamiStoryPollution> pollutionLevelMap = HonamiStoryModel.Instance.PollutionLevelMap;
			IHonamiStoryPollution honamiStoryPollution;
			int num2 = (pollutionLevelMap != null && pollutionLevelMap.TryGetValue(pollutionLevel2, out honamiStoryPollution)) ? honamiStoryPollution.MonsterEnhanceLevel : 0;
			if (pollutionLevel != 0 && pollutionLevel < pollutionLevel2 && num > 0L)
			{
				IHonamiStoryPollution honamiStoryPollution2;
				int num3 = (pollutionLevelMap != null && pollutionLevelMap.TryGetValue(pollutionLevel, out honamiStoryPollution2)) ? honamiStoryPollution2.MonsterEnhanceLevel : 0;
				HonamiStoryPollutionUpdateParams param = new HonamiStoryPollutionUpdateParams
				{
					PollutionLevel = pollutionLevel2,
					MonsterIncreaseLevel = num2 - num3
				};
				UiManager.Instance.OpenView(EUiViewName.HonamiStoryPollutionLevelUpdateView, param, null);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnHonamiStoryPollutionUpdate, num2);
		}

		// Token: 0x0602EEBB RID: 192187 RVA: 0x00D18124 File Offset: 0x00D16324
		[NullableContext(2)]
		private void OnHonamiStoryInstSettleNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryInstSettleNotify honamiStoryInstSettleNotify = (HonamiStoryInstSettleNotify)msg;
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
			List<IHonamiStorySettleItemParams> list = new List<IHonamiStorySettleItemParams>();
			list.Add(new HonamiStorySettleItemParams
			{
				Name = "HonamiStory_EvacuationInterface_2",
				Value = TimeUtil.Instance.GetTimeString((double)honamiStoryInstSettleNotify.UseTime)
			});
			list.Add(new HonamiStorySettleItemParams
			{
				Name = "HonamiStory_EvacuationInterface_8",
				Value = honamiStoryInstSettleNotify.InnerCoin.ToString()
			});
			list.Add(new HonamiStorySettleItemParams
			{
				Name = "HonamiStory_EvacuationInterface_1",
				Value = honamiStoryInstSettleNotify.ItemTotalValue.ToString()
			});
			int talentAdd = honamiStoryInstSettleNotify.TalentAdd;
			if (talentAdd > 0)
			{
				list.Add(new HonamiStorySettleItemParams
				{
					Name = "HonamiStory_EvacuationInterface_3",
					Value = talentAdd.ToString()
				});
			}
			this.SetHonamiStoryLoadingInfoByResult(honamiStoryInstSettleNotify.IsSuccess);
			if (honamiStoryInstSettleNotify.IsSuccess)
			{
				HonamiStorySettleSuccessViewParams param = new HonamiStorySettleSuccessViewParams
				{
					DisplayItems = list,
					TotalReward = honamiStoryInstSettleNotify.TotalValue,
					IsNewRecord = honamiStoryInstSettleNotify.IsUpdateTotalValue
				};
				UiManager.Instance.OpenView(EUiViewName.HonamiStorySettleSuccessView, param, null);
				return;
			}
			HonamiStorySettleFailViewParams failParams = new HonamiStorySettleFailViewParams
			{
				DisplayItems = list,
				TotalReward = honamiStoryInstSettleNotify.TotalValue,
				IsNewRecord = honamiStoryInstSettleNotify.IsUpdateTotalValue,
				FailAddProportion = (int)Math.Round((double)honamiStoryInstSettleNotify.FailAddProportion / 100.0)
			};
			if (!honamiStoryInstSettleNotify.IsDeadSettle)
			{
				UiManager.Instance.OpenView(EUiViewName.HonamiStorySettleFailView, failParams, null);
				return;
			}
			UiManager.Instance.ResetToBattleView(null);
			Action<bool> <>9__1;
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiManager instance = UiManager.Instance;
				Action<bool> callback;
				if ((callback = <>9__1) == null)
				{
					callback = (<>9__1 = delegate(bool _)
					{
						UiManager.Instance.OpenView(EUiViewName.HonamiStorySettleFailView, failParams, null);
					});
				}
				instance.ResetToBattleView(callback);
			}, 3000f, null, null, true, 1f);
		}

		// Token: 0x0602EEBC RID: 192188 RVA: 0x00D182E4 File Offset: 0x00D164E4
		[NullableContext(2)]
		private void OnHonamiStoryInstTopTowerSettleNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryInstTopTowerSettleNotify honamiStoryInstTopTowerSettleNotify = (HonamiStoryInstTopTowerSettleNotify)msg;
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
			int costItemId = 0;
			int costNum = 0;
			int dangerLevel = HonamiStoryModel.Instance.DangerLevel;
			if (dangerLevel > 0)
			{
				HonamiStoryDangerLevel? config = ConfigHonamiStoryDangerLevelById.GetConfig(dangerLevel, true);
				if (config != null)
				{
					Dictionary<int, int> dictionary = config.Value.ConsumeItems();
					if (dictionary != null && dictionary.Count > 0)
					{
						using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								KeyValuePair<int, int> keyValuePair = enumerator.Current;
								costItemId = keyValuePair.Key;
								costNum = keyValuePair.Value;
							}
						}
					}
				}
			}
			List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
			list.Add(new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_217_ButtonText_0",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = false,
				OnClickedCallback = delegate(int _)
				{
					this.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.LeaveTower);
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				}
			});
			bool needCost = costItemId > 0 && costNum > 0;
			List<string> list2 = new List<string>();
			if (needCost)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(costItemId, 0);
				string item = itemCountByConfigId.ToString();
				if (itemCountByConfigId < costNum)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#c25757>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					item = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				list2.Add(item);
				string iconSmall = InventoryConfig.Instance.GetItemConfigData(costItemId).IconSmall;
				string item2 = "<texture=" + iconSmall + "/>";
				list2.Add(item2);
			}
			Action <>9__2;
			list.Add(new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_133_ButtonText_1",
				DescriptionTextId = (needCost ? "Text_RemainText_Text" : null),
				DescriptionArgs = (needCost ? new List<object>(list2) : null),
				IsTimeDownCloseView = false,
				IsClickedCloseView = false,
				OnClickedCallback = delegate(int _)
				{
					if (needCost)
					{
						ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.HonamiStoryTowerRestart);
						Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
						int key = 2;
						Action value;
						if ((value = <>9__2) == null)
						{
							value = (<>9__2 = delegate()
							{
								if (InventoryModel.Instance.GetItemCountByConfigId(costItemId, 0) < costNum)
								{
									ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_InsufficientBalance", Array.Empty<object>());
									return;
								}
								this.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.Tower);
								InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false);
							});
						}
						functionMap.Add(key, value);
						ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
						return;
					}
					this.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.Tower);
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false);
				}
			});
			List<RewardItemData> list3 = new List<RewardItemData>();
			foreach (Aki.Protocol.RewardItem rewardItem in honamiStoryInstTopTowerSettleNotify.RewardItems)
			{
				RewardItemData item3 = new RewardItemData(rewardItem.Id, rewardItem.Count, null, EDropItemType.Normal);
				list3.Add(item3);
			}
			List<IHonamiTowerRecordData> list4 = new List<IHonamiTowerRecordData>();
			list4.Add(new HonamiTowerRecordData
			{
				RecordName = "HonamiStory_EvacuationInterface_5",
				RecordValue = honamiStoryInstTopTowerSettleNotify.DangerLevel.ToString()
			});
			list4.Add(new HonamiTowerRecordData
			{
				RecordName = "HonamiStory_EvacuationInterface_6",
				RecordValue = honamiStoryInstTopTowerSettleNotify.PassFloor.ToString()
			});
			list4.Add(new HonamiTowerRecordData
			{
				RecordName = "HonamiStory_EvacuationInterface_7",
				RecordValue = TimeUtil.Instance.GetTimeString((double)honamiStoryInstTopTowerSettleNotify.UseTime)
			});
			IHonamiTowerRecordData[] array = new IHonamiTowerRecordData[list4.Count];
			for (int i = 0; i < list4.Count; i++)
			{
				array[i] = list4[i];
			}
			RewardItemData[] array2 = new RewardItemData[list3.Count];
			for (int j = 0; j < list3.Count; j++)
			{
				array2[j] = list3[j];
			}
			HonamiTowerSuccessData honamiTowerSuccessData = new HonamiTowerSuccessData
			{
				RecordItemList = array,
				RewardItemList = array2
			};
			ItemRewardModel.Instance.ClearCurrentRewardData();
			ItemRewardController.Instance.OpenExploreRewardViewNew(new ExploreRewardViewData
			{
				ConfigId = 3031,
				IsSuccess = true,
				ButtonInfoList = list,
				HonamiTowerSuccessData = honamiTowerSuccessData,
				IsBagFull = new bool?(false)
			});
		}

		// Token: 0x0602EEBD RID: 192189 RVA: 0x00D186DC File Offset: 0x00D168DC
		private void OnLeaveDungeon()
		{
			if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
			{
				HonamiStoryQuestDataBase curTrackTaskData = HonamiStoryModel.Instance.CurTrackTaskData;
				if (curTrackTaskData != null)
				{
					global::LevelPlayInfo levelPlayInfo = curTrackTaskData.GetLevelPlayInfo();
					if (levelPlayInfo != null)
					{
						levelPlayInfo.ResetTrackPriorityOverride();
					}
				}
				HonamiStoryModel.Instance.RemoveBackPack(2);
				HonamiStoryModel.Instance.RemoveBackPack(3);
				FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnHonamiStoryLifeSupportChanged));
			}
		}

		// Token: 0x0602EEBE RID: 192190 RVA: 0x00D1873C File Offset: 0x00D1693C
		private void OnEnterDungeon(int _1, int _2)
		{
			if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
			{
				FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnHonamiStoryLifeSupportChanged), null);
			}
		}

		// Token: 0x0602EEBF RID: 192191 RVA: 0x00D18760 File Offset: 0x00D16960
		private void OnWorldDoneAndCloseLoading()
		{
			if (HonamiStoryModel.Instance.CacheShowSafeLeaveUpdate)
			{
				this.ShowSafeLeaveUpdate();
			}
			if (HonamiStoryUtil.CheckInHonamiStoryAreaDungeon())
			{
				Log.Instance.Info(ELogModule.HonamiStory, ELogAuthor.LRC, "OnWorldDoneAndCloseLoading 自动追踪第一个未完成的支线任务", default(ReadOnlySpan<ValueTuple<string, object>>));
				HonamiStoryModel.Instance.InitSubQuestTrack();
			}
		}

		// Token: 0x0602EEC0 RID: 192192 RVA: 0x00D187AF File Offset: 0x00D169AF
		private void OnHonamiStoryLifeSupportChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<float, float>(EEventName.OnHonamiStoryLifeSupportChanged, oldValue, newValue);
		}

		// Token: 0x0602EEC1 RID: 192193 RVA: 0x00D187C4 File Offset: 0x00D169C4
		[NullableContext(2)]
		private void OnHonamiStoryMascotInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryMascotInfoUpdateNotify honamiStoryMascotInfoUpdateNotify = (HonamiStoryMascotInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).UpdateHonamiStoryMascotDataList(honamiStoryMascotInfoUpdateNotify.HonamiStoryMascotInfos);
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMascotUnlockSet, null) ?? new HashSet<int>();
			foreach (HonamiStoryMascotInfo honamiStoryMascotInfo in honamiStoryMascotInfoUpdateNotify.HonamiStoryMascotInfos)
			{
				if (honamiStoryMascotInfo.Status == 1)
				{
					hashSet.Add(honamiStoryMascotInfo.HonamiStoryMascotId);
				}
			}
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMascotUnlockSet, hashSet);
		}

		// Token: 0x0602EEC2 RID: 192194 RVA: 0x00D18860 File Offset: 0x00D16A60
		public void SendHonamiStoryMascotRewardRequest(int mascotId, Action callback)
		{
			HonamiStoryMascotRewardRequest honamiStoryMascotRewardRequest = HonamiStoryMascotRewardRequest.Create();
			honamiStoryMascotRewardRequest.HonamiStoryMascotId = mascotId;
			Net.Instance.Call(ERequestMessageId.HonamiStoryMascotRewardRequest, honamiStoryMascotRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryMascotRewardResponse honamiStoryMascotRewardResponse = (HonamiStoryMascotRewardResponse)msg;
				if (honamiStoryMascotRewardResponse == null)
				{
					return;
				}
				if (honamiStoryMascotRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryMascotRewardResponse.ErrorCode, 28960, null, true, true);
					return;
				}
				HonamiStoryModel.Instance.GetActivityData(true).GetHonamiStoryMascotData(mascotId).UpdateState(EHonamiStoryCollectState.GotReward);
				EventSystem.Instance.Emit<int>(EEventName.OnHonamiStoryMascotRewardReceive, mascotId);
				callback();
			}, 0);
		}

		// Token: 0x0602EEC3 RID: 192195 RVA: 0x00D188B0 File Offset: 0x00D16AB0
		[NullableContext(2)]
		private void OnHonamiStoryAreaInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAreaInfoUpdateNotify honamiStoryAreaInfoUpdateNotify = (HonamiStoryAreaInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).UpdateHonamiStoryAreaDataList(honamiStoryAreaInfoUpdateNotify.HonamiStoryAreaInfo);
		}

		// Token: 0x0602EEC4 RID: 192196 RVA: 0x00D188DC File Offset: 0x00D16ADC
		public void SendHonamiStoryAreaSecretRewardRequest(int areaSecretId, Action callback)
		{
			HonamiStoryAreaSecretRewardRequest honamiStoryAreaSecretRewardRequest = HonamiStoryAreaSecretRewardRequest.Create();
			honamiStoryAreaSecretRewardRequest.AreaSecretId = areaSecretId;
			Net.Instance.Call(ERequestMessageId.HonamiStoryAreaSecretRewardRequest, honamiStoryAreaSecretRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryAreaSecretRewardResponse honamiStoryAreaSecretRewardResponse = (HonamiStoryAreaSecretRewardResponse)msg;
				if (honamiStoryAreaSecretRewardResponse == null)
				{
					return;
				}
				if (honamiStoryAreaSecretRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryAreaSecretRewardResponse.ErrorCode, 21464, null, true, true);
					return;
				}
				HonamiStoryModel.Instance.GetActivityData(true).GetHonamiStoryAreaData(areaSecretId).UpdateCollectMascotState(EHonamiStoryCollectState.GotReward);
				EventSystem.Instance.Emit<int>(EEventName.OnHonamiStoryAreaSecretRewardReceive, areaSecretId);
				callback();
			}, 0);
		}

		// Token: 0x0602EEC5 RID: 192197 RVA: 0x00D1892C File Offset: 0x00D16B2C
		[NullableContext(0)]
		public UniTask<bool> LeaveHonamiDungeon()
		{
			HonamiStoryController.<LeaveHonamiDungeon>d__31 <LeaveHonamiDungeon>d__;
			<LeaveHonamiDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LeaveHonamiDungeon>d__.<>1__state = -1;
			<LeaveHonamiDungeon>d__.<>t__builder.Start<HonamiStoryController.<LeaveHonamiDungeon>d__31>(ref <LeaveHonamiDungeon>d__);
			return <LeaveHonamiDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEC6 RID: 192198 RVA: 0x00D18967 File Offset: 0x00D16B67
		public bool CanOpenBackpack(EUiViewName viewName, object _)
		{
			return FunctionModel.Instance.IsOpen(10102);
		}

		// Token: 0x0602EEC7 RID: 192199 RVA: 0x00D18978 File Offset: 0x00D16B78
		[NullableContext(2)]
		private void OnHonamiStorySetFormationNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStorySetFormationNotify honamiStorySetFormationNotify = (HonamiStorySetFormationNotify)msg;
			HonamiStoryPlayerBackpackData playerBackpackData = HonamiStoryModel.Instance.GetPlayerBackpackData();
			playerBackpackData.RefreshEquipInfo(honamiStorySetFormationNotify.HonamiStoryRackInfos);
			if (honamiStorySetFormationNotify.EquipRack != null)
			{
				playerBackpackData.RefreshGridItemInfo(honamiStorySetFormationNotify.EquipRack.HonamiStoryBagItemInfos);
			}
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
		}

		// Token: 0x0602EEC8 RID: 192200 RVA: 0x00D189C8 File Offset: 0x00D16BC8
		[NullableContext(2)]
		private void OnHonamiStoryBagInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryBagInfoUpdateNotify updateInfo = (HonamiStoryBagInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.UpdateBackpackInfo(updateInfo);
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
		}

		// Token: 0x0602EEC9 RID: 192201 RVA: 0x00D189F4 File Offset: 0x00D16BF4
		[NullableContext(0)]
		public UniTask<bool> SendHonamiStoryBagOperateRequest([Nullable(1)] List<HonamiStoryBagUpdateContext> updateContext)
		{
			HonamiStoryController.<SendHonamiStoryBagOperateRequest>d__35 <SendHonamiStoryBagOperateRequest>d__;
			<SendHonamiStoryBagOperateRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SendHonamiStoryBagOperateRequest>d__.updateContext = updateContext;
			<SendHonamiStoryBagOperateRequest>d__.<>1__state = -1;
			<SendHonamiStoryBagOperateRequest>d__.<>t__builder.Start<HonamiStoryController.<SendHonamiStoryBagOperateRequest>d__35>(ref <SendHonamiStoryBagOperateRequest>d__);
			return <SendHonamiStoryBagOperateRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602EECA RID: 192202 RVA: 0x00D18A38 File Offset: 0x00D16C38
		public void RequestHonamiStoryEquipRole(IEnumerable<int> roleList)
		{
			HonamiStoryEquipRoleRequest honamiStoryEquipRoleRequest = HonamiStoryEquipRoleRequest.Create();
			honamiStoryEquipRoleRequest.ActivityId = HonamiStoryModel.Instance.ActivityId;
			honamiStoryEquipRoleRequest.RoleId.Add(roleList);
			Net.Instance.Call(ERequestMessageId.HonamiStoryEquipRoleRequest, honamiStoryEquipRoleRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryEquipRoleResponse honamiStoryEquipRoleResponse = (HonamiStoryEquipRoleResponse)msg;
				if (honamiStoryEquipRoleResponse == null)
				{
					return;
				}
				if (honamiStoryEquipRoleResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryEquipRoleResponse.ErrorCode, 27622, null, true, true);
					return;
				}
				RepeatedField<int> roleId = honamiStoryEquipRoleResponse.RoleId;
				HonamiStoryModel.Instance.UpdateRoleList(new List<int>(roleId));
				EventSystem.Instance.Emit(EEventName.OnHonamiStoryRoleEquipChanged);
				HonamiStoryModel.Instance.SetQuickAllDirty(true);
			}, 0);
		}

		// Token: 0x0602EECB RID: 192203 RVA: 0x00D18A98 File Offset: 0x00D16C98
		[NullableContext(0)]
		public UniTask<bool> SendHonamiStoryPickUpItemRequest(int backpackId, [Nullable(1)] HonamiStoryItemDataBase itemData, int position)
		{
			HonamiStoryController.<SendHonamiStoryPickUpItemRequest>d__37 <SendHonamiStoryPickUpItemRequest>d__;
			<SendHonamiStoryPickUpItemRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SendHonamiStoryPickUpItemRequest>d__.backpackId = backpackId;
			<SendHonamiStoryPickUpItemRequest>d__.itemData = itemData;
			<SendHonamiStoryPickUpItemRequest>d__.position = position;
			<SendHonamiStoryPickUpItemRequest>d__.<>1__state = -1;
			<SendHonamiStoryPickUpItemRequest>d__.<>t__builder.Start<HonamiStoryController.<SendHonamiStoryPickUpItemRequest>d__37>(ref <SendHonamiStoryPickUpItemRequest>d__);
			return <SendHonamiStoryPickUpItemRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602EECC RID: 192204 RVA: 0x00D18AEC File Offset: 0x00D16CEC
		[NullableContext(0)]
		public UniTask<bool> HonamiStoryPickAndEquipRequest([Nullable(1)] HonamiStoryItemDataBase itemData, int pos)
		{
			HonamiStoryController.<HonamiStoryPickAndEquipRequest>d__38 <HonamiStoryPickAndEquipRequest>d__;
			<HonamiStoryPickAndEquipRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<HonamiStoryPickAndEquipRequest>d__.itemData = itemData;
			<HonamiStoryPickAndEquipRequest>d__.pos = pos;
			<HonamiStoryPickAndEquipRequest>d__.<>1__state = -1;
			<HonamiStoryPickAndEquipRequest>d__.<>t__builder.Start<HonamiStoryController.<HonamiStoryPickAndEquipRequest>d__38>(ref <HonamiStoryPickAndEquipRequest>d__);
			return <HonamiStoryPickAndEquipRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602EECD RID: 192205 RVA: 0x00D18B38 File Offset: 0x00D16D38
		public void SendHonamiStoryDiscardItemRequest(HonamiStoryBagUpdateContext updateContext)
		{
			HonamiStoryDiscardItemRequest request = HonamiStoryDiscardItemRequest.Create();
			request.HonamiStoryBagUpdateContext = updateContext;
			Net.Instance.Call(ERequestMessageId.HonamiStoryDiscardItemRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryDiscardItemResponse honamiStoryDiscardItemResponse = (HonamiStoryDiscardItemResponse)msg;
				if (honamiStoryDiscardItemResponse == null)
				{
					return;
				}
				if (honamiStoryDiscardItemResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryDiscardItemResponse.ErrorCode, 20810, null, true, true);
					return;
				}
				bool flag = updateContext.BackPackConfigId == 4;
				if (!flag && updateContext.BackPackConfigId != 3)
				{
					HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(2, false);
					using (IEnumerator<HonamiStoryBagUpdateInfo> enumerator = updateContext.HonamiStoryBagUpdateInfo.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo = enumerator.Current;
							HonamiStoryItemDataBase honamiStoryItemDataBase = (backPackData != null) ? backPackData.GetItemDataByInstanceId(honamiStoryBagUpdateInfo.ItemIncrId, true) : null;
							if (honamiStoryItemDataBase != null)
							{
								HonamiStoryModel.Instance.ShowDiscardTips(honamiStoryItemDataBase);
								if (honamiStoryItemDataBase.GetItemType() == EHonamiStoryItemType.Plugin)
								{
									flag = true;
									break;
								}
							}
						}
						goto IL_10E;
					}
				}
				foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo2 in updateContext.HonamiStoryBagUpdateInfo)
				{
					HonamiStoryItemDataBase equipItemDataByIncId = HonamiStoryModel.Instance.GetEquipItemDataByIncId(honamiStoryBagUpdateInfo2.ItemIncrId);
					if (equipItemDataByIncId != null)
					{
						HonamiStoryModel.Instance.ShowDiscardTips(equipItemDataByIncId);
					}
				}
				IL_10E:
				HonamiStoryModel.Instance.UpdateBackPackContext(new List<HonamiStoryBagUpdateContext>
				{
					request.HonamiStoryBagUpdateContext
				});
				EventSystem.Instance.Emit<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, updateContext);
				if (flag)
				{
					HonamiStoryModel.Instance.SetQuickAllDirty(true);
				}
			}, 0);
		}

		// Token: 0x0602EECE RID: 192206 RVA: 0x00D18B90 File Offset: 0x00D16D90
		[NullableContext(2)]
		private void OnHonamiStoryBagSizeUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			MapField<int, int> bagSize = ((HonamiStoryBagSizeUpdateNotify)msg).BagSize;
			HonamiStoryModel.Instance.UpdateBackpackSize(new Dictionary<int, int>(bagSize));
		}

		// Token: 0x0602EECF RID: 192207 RVA: 0x00D18BBC File Offset: 0x00D16DBC
		[NullableContext(0)]
		public UniTask<bool> RequestHonamiStoryUnlockSlot([Nullable(1)] HonamiStoryRoleEquipSlotData slotData, int rolePos)
		{
			HonamiStoryController.<RequestHonamiStoryUnlockSlot>d__41 <RequestHonamiStoryUnlockSlot>d__;
			<RequestHonamiStoryUnlockSlot>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestHonamiStoryUnlockSlot>d__.slotData = slotData;
			<RequestHonamiStoryUnlockSlot>d__.rolePos = rolePos;
			<RequestHonamiStoryUnlockSlot>d__.<>1__state = -1;
			<RequestHonamiStoryUnlockSlot>d__.<>t__builder.Start<HonamiStoryController.<RequestHonamiStoryUnlockSlot>d__41>(ref <RequestHonamiStoryUnlockSlot>d__);
			return <RequestHonamiStoryUnlockSlot>d__.<>t__builder.Task;
		}

		// Token: 0x0602EED0 RID: 192208 RVA: 0x00D18C08 File Offset: 0x00D16E08
		[return: Nullable(0)]
		public UniTask<bool> RequestHonamiStoryQuickUnloadAll(List<HonamiStoryItemDataBase> itemList, HashSet<int> posList, EHonamiStoryBackpack backpack)
		{
			HonamiStoryController.<RequestHonamiStoryQuickUnloadAll>d__42 <RequestHonamiStoryQuickUnloadAll>d__;
			<RequestHonamiStoryQuickUnloadAll>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestHonamiStoryQuickUnloadAll>d__.itemList = itemList;
			<RequestHonamiStoryQuickUnloadAll>d__.posList = posList;
			<RequestHonamiStoryQuickUnloadAll>d__.backpack = backpack;
			<RequestHonamiStoryQuickUnloadAll>d__.<>1__state = -1;
			<RequestHonamiStoryQuickUnloadAll>d__.<>t__builder.Start<HonamiStoryController.<RequestHonamiStoryQuickUnloadAll>d__42>(ref <RequestHonamiStoryQuickUnloadAll>d__);
			return <RequestHonamiStoryQuickUnloadAll>d__.<>t__builder.Task;
		}

		// Token: 0x0602EED1 RID: 192209 RVA: 0x00D18C5C File Offset: 0x00D16E5C
		[NullableContext(2)]
		private void OnHonamiStoryPermanentTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryResidentTaskInfoUpdateNotify honamiStoryResidentTaskInfoUpdateNotify = (HonamiStoryResidentTaskInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdatePermanentTaskDataList(honamiStoryResidentTaskInfoUpdateNotify.ConditionTasks);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}

		// Token: 0x0602EED2 RID: 192210 RVA: 0x00D18CA0 File Offset: 0x00D16EA0
		public void SendHonamiStoryPermanentTaskRewardRequest(List<int> taskIds, Action callback)
		{
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			HonamiStoryResidentTaskRewardRequest honamiStoryResidentTaskRewardRequest = HonamiStoryResidentTaskRewardRequest.Create();
			honamiStoryResidentTaskRewardRequest.ActivityId = activityData.Id;
			honamiStoryResidentTaskRewardRequest.ResidentTaskIds.Add(taskIds);
			Net.Instance.Call(ERequestMessageId.HonamiStoryResidentTaskRewardRequest, honamiStoryResidentTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryResidentTaskRewardResponse honamiStoryResidentTaskRewardResponse = (HonamiStoryResidentTaskRewardResponse)msg;
				if (honamiStoryResidentTaskRewardResponse == null)
				{
					return;
				}
				if (honamiStoryResidentTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryResidentTaskRewardResponse.ErrorCode, 15037, null, true, true);
					return;
				}
				foreach (int id in taskIds)
				{
					activityData.GetPermanentTaskData(id).UpdateState(EActivityTaskState.FinishedAndClaimed);
				}
				callback();
			}, 0);
		}

		// Token: 0x0602EED3 RID: 192211 RVA: 0x00D18D18 File Offset: 0x00D16F18
		[NullableContext(2)]
		private void OnHonamiStoryLimitTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryLimitTaskInfoUpdateNotify honamiStoryLimitTaskInfoUpdateNotify = (HonamiStoryLimitTaskInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdateLimitTaskDataList(honamiStoryLimitTaskInfoUpdateNotify.ConditionTasks);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}

		// Token: 0x0602EED4 RID: 192212 RVA: 0x00D18D5C File Offset: 0x00D16F5C
		public void SendHonamiStoryLimitTaskRewardRequest(List<int> taskIds, Action callback)
		{
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			HonamiStoryLimitTaskRewardRequest honamiStoryLimitTaskRewardRequest = HonamiStoryLimitTaskRewardRequest.Create();
			honamiStoryLimitTaskRewardRequest.ActivityId = activityData.Id;
			honamiStoryLimitTaskRewardRequest.LimitTaskIds.Add(taskIds);
			Net.Instance.Call(ERequestMessageId.HonamiStoryLimitTaskRewardRequest, honamiStoryLimitTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryLimitTaskRewardResponse honamiStoryLimitTaskRewardResponse = (HonamiStoryLimitTaskRewardResponse)msg;
				if (honamiStoryLimitTaskRewardResponse == null)
				{
					return;
				}
				if (honamiStoryLimitTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryLimitTaskRewardResponse.ErrorCode, 20813, null, true, true);
					return;
				}
				foreach (int id in taskIds)
				{
					activityData.GetLimitTaskData(id).UpdateState(EActivityTaskState.FinishedAndClaimed);
				}
				callback();
			}, 0);
		}

		// Token: 0x0602EED5 RID: 192213 RVA: 0x00D18DD4 File Offset: 0x00D16FD4
		[NullableContext(2)]
		public void OnHonamiStoryScoreRewardInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryScoreRewardInfoUpdateNotify honamiStoryScoreRewardInfoUpdateNotify = (HonamiStoryScoreRewardInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdateScoreRewardDataList(honamiStoryScoreRewardInfoUpdateNotify.HonamiStoryScoreRewardInfos);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}

		// Token: 0x0602EED6 RID: 192214 RVA: 0x00D18E18 File Offset: 0x00D17018
		public void SendHonamiStoryScoreRewardRequest(List<int> scoreRewardIds, Action callback)
		{
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			HonamiStoryScoreRewardRequest honamiStoryScoreRewardRequest = HonamiStoryScoreRewardRequest.Create();
			honamiStoryScoreRewardRequest.ActivityId = activityData.Id;
			honamiStoryScoreRewardRequest.ScoreRewardId.Add(scoreRewardIds);
			Net.Instance.Call(ERequestMessageId.HonamiStoryScoreRewardRequest, honamiStoryScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryScoreRewardResponse honamiStoryScoreRewardResponse = (HonamiStoryScoreRewardResponse)msg;
				if (honamiStoryScoreRewardResponse == null)
				{
					return;
				}
				if (honamiStoryScoreRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryScoreRewardResponse.ErrorCode, 27500, null, true, true);
					return;
				}
				HonamiStoryActivityData activityData2 = HonamiStoryModel.Instance.GetActivityData(true);
				foreach (int scoreRewardId in scoreRewardIds)
				{
					activityData2.GetScoreRewardData(scoreRewardId).UpdateState(EHonamiStoryCollectState.GotReward);
				}
				callback();
			}, 0);
		}

		// Token: 0x0602EED7 RID: 192215 RVA: 0x00D18E88 File Offset: 0x00D17088
		[NullableContext(2)]
		private void OnHonamiStoryAddWeaponNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAddWeaponNotify honamiStoryAddWeaponNotify = (HonamiStoryAddWeaponNotify)msg;
			HonamiStoryModel.Instance.UpdateWeaponDataList(honamiStoryAddWeaponNotify.WeaponIds);
			List<RewardItemData> list = new List<RewardItemData>();
			foreach (int num in honamiStoryAddWeaponNotify.WeaponIds)
			{
				HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>();
				hashSet.Add(num);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, hashSet);
				HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(num);
				if (weaponData != null && weaponData.IsShowReward)
				{
					RewardItemData item = new RewardItemData(num, 1, null, EDropItemType.Normal);
					list.Add(item);
				}
			}
			if (list.Count > 0)
			{
				this.OpenHonamiWeaponRewardView(list);
			}
		}

		// Token: 0x0602EED8 RID: 192216 RVA: 0x00D18F60 File Offset: 0x00D17160
		public void SendHonamiStoryWeaponDressRequest(int selectWeaponId, int selectPosition, Action callback)
		{
			HonamiStoryWeaponDressRequest honamiStoryWeaponDressRequest = HonamiStoryWeaponDressRequest.Create();
			honamiStoryWeaponDressRequest.WeaponItemId = selectWeaponId;
			honamiStoryWeaponDressRequest.RackIndex = selectPosition;
			honamiStoryWeaponDressRequest.ActivityId = HonamiStoryModel.Instance.ActivityId;
			Net.Instance.Call(ERequestMessageId.HonamiStoryWeaponDressRequest, honamiStoryWeaponDressRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryWeaponDressResponse honamiStoryWeaponDressResponse = (HonamiStoryWeaponDressResponse)msg;
				if (honamiStoryWeaponDressResponse == null)
				{
					return;
				}
				if (honamiStoryWeaponDressResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryWeaponDressResponse.ErrorCode, 26893, null, true, true);
					return;
				}
				int weaponItemId = honamiStoryWeaponDressResponse.WeaponItemId;
				int rackIndex = honamiStoryWeaponDressResponse.RackIndex;
				HonamiStoryRoleEquipData weaponEquipState = HonamiStoryModel.Instance.GetWeaponEquipState(weaponItemId);
				if (weaponEquipState != null)
				{
					int position = weaponEquipState.GetPosition();
					HonamiStoryRoleEquipData roleEquipDataByPosition = HonamiStoryModel.Instance.GetRoleEquipDataByPosition(rackIndex);
					int weaponId = (roleEquipDataByPosition != null) ? roleEquipDataByPosition.GetWeaponId() : 0;
					HonamiStoryModel.Instance.UpdateWeaponByPosition(weaponId, position);
				}
				HonamiStoryModel.Instance.UpdateWeaponByPosition(weaponItemId, rackIndex);
				callback();
				EventSystem.Instance.Emit(EEventName.OnHonamiStoryRoleEquipChanged);
				HonamiStoryModel.Instance.SetQuickAllDirty(true);
			}, 0);
		}

		// Token: 0x0602EED9 RID: 192217 RVA: 0x00D18FBC File Offset: 0x00D171BC
		[NullableContext(2)]
		private void OnHonamiStoryItemCollectionInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryItemCollectionInfoUpdateNotify honamiStoryItemCollectionInfoUpdateNotify = (HonamiStoryItemCollectionInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).UpdateItemCollectionDataList(honamiStoryItemCollectionInfoUpdateNotify.HonamiStoryItemCollectionInfos);
		}

		// Token: 0x0602EEDA RID: 192218 RVA: 0x00D18FE8 File Offset: 0x00D171E8
		public void SendHonamiStoryItemEnterRequest(bool isTower, int dangerLv, bool isBuy)
		{
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			int count = activityData.GetHonamiStoryAreaDataList().Count;
			if (!isTower && dangerLv <= count && !activityData.GetHonamiStoryAreaData(dangerLv).IsAreaCanEnter)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_LevelUnlockedPrompt", Array.Empty<object>());
				return;
			}
			HonamiStoryEnterCtx honamiStoryEnterCtx = new HonamiStoryEnterCtx
			{
				IsUpTower = isTower,
				DangerLevel = dangerLv,
				BuySafeLeave = isBuy,
				ActivityId = activityData.Id
			};
			InstanceDungeonModel.Instance.InstanceEnterContentText.HonamiStoryEnterCtx = honamiStoryEnterCtx;
			IEnumerable<int> allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
			int areaInstId = activityData.AreaInstId;
			List<int> roleIds = new List<int>(allRoleIdList);
			InstanceDungeonController.Instance.PrewarTeamFightRequest(areaInstId, roleIds, 0, 0, null, null).ContinueWith(delegate(bool value)
			{
				HonamiStoryModel.Instance.SetQuickAllDirty(true);
			});
		}

		// Token: 0x0602EEDB RID: 192219 RVA: 0x00D190BC File Offset: 0x00D172BC
		public void SendHonamiStoryItemCollectionRequest(List<int> itemCollectionIdList)
		{
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			HonamiStoryItemCollectionRequest honamiStoryItemCollectionRequest = HonamiStoryItemCollectionRequest.Create();
			honamiStoryItemCollectionRequest.HonamiStoryItemCollectionId.Add(itemCollectionIdList);
			honamiStoryItemCollectionRequest.ActivityId = activityData.Id;
			Net.Instance.Call(ERequestMessageId.HonamiStoryItemCollectionRequest, honamiStoryItemCollectionRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryItemCollectionResponse honamiStoryItemCollectionResponse = (HonamiStoryItemCollectionResponse)msg;
				if (honamiStoryItemCollectionResponse == null)
				{
					return;
				}
				if (honamiStoryItemCollectionResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryItemCollectionResponse.ErrorCode, 17176, null, true, true);
					return;
				}
				if (honamiStoryItemCollectionResponse.HonamiStoryItemCollectionId.Count <= 0)
				{
					return;
				}
				foreach (int id in honamiStoryItemCollectionResponse.HonamiStoryItemCollectionId)
				{
					activityData.GetItemCollectionData(id).UpdateState(EHonamiStoryCollectState.GotReward);
				}
				EventSystem.Instance.Emit(EEventName.OnHonamiStoryItemCollectGetReward);
			}, 0);
		}

		// Token: 0x0602EEDC RID: 192220 RVA: 0x00D19120 File Offset: 0x00D17320
		public void SendHonamiStoryActivateTalentRequest(int talentId, Action callback)
		{
			HonamiStoryActivateTalentRequest honamiStoryActivateTalentRequest = HonamiStoryActivateTalentRequest.Create();
			honamiStoryActivateTalentRequest.TalentId = talentId;
			Net.Instance.Call(ERequestMessageId.HonamiStoryActivateTalentRequest, honamiStoryActivateTalentRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HonamiStoryActivateTalentResponse honamiStoryActivateTalentResponse = (HonamiStoryActivateTalentResponse)msg;
				if (honamiStoryActivateTalentResponse == null)
				{
					return;
				}
				if (honamiStoryActivateTalentResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryActivateTalentResponse.ErrorCode, 16479, null, true, true);
					return;
				}
				callback();
			}, 0);
		}

		// Token: 0x0602EEDD RID: 192221 RVA: 0x00D19164 File Offset: 0x00D17364
		[NullableContext(2)]
		private void OnHonamiStoryTalentInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryTalentInfoUpdateNotify honamiStoryTalentInfoUpdateNotify = (HonamiStoryTalentInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.RefreshTalentInfos(honamiStoryTalentInfoUpdateNotify.HonamiStoryTalentInfos);
			EventSystem.Instance.Emit(EEventName.OnHonamiStoryTechNodeLevelUpdate);
		}

		// Token: 0x0602EEDE RID: 192222 RVA: 0x00D19198 File Offset: 0x00D17398
		[NullableContext(2)]
		private void OnHonamiStoryTotalRevenueNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryTotalRevenueNotify honamiStoryTotalRevenueNotify = (HonamiStoryTotalRevenueNotify)msg;
			HonamiStoryModel.Instance.SetTotalRevenueInternal(honamiStoryTotalRevenueNotify.TotalRevenue);
		}

		// Token: 0x0602EEDF RID: 192223 RVA: 0x00D191BC File Offset: 0x00D173BC
		[NullableContext(2)]
		private void OnHonamiStoryAreaTaskInfoRefreshNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAreaTaskInfoRefreshNotify honamiStoryAreaTaskInfoRefreshNotify = (HonamiStoryAreaTaskInfoRefreshNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).InitSubQuestTaskDataList(honamiStoryAreaTaskInfoRefreshNotify.ConditionTasks);
		}

		// Token: 0x0602EEE0 RID: 192224 RVA: 0x00D191E8 File Offset: 0x00D173E8
		[NullableContext(2)]
		private void OnHonamiStoryAreaTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAreaTaskInfoUpdateNotify honamiStoryAreaTaskInfoUpdateNotify = (HonamiStoryAreaTaskInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdateSubQuestTaskDataList(honamiStoryAreaTaskInfoUpdateNotify.ConditionTasks);
			foreach (ConditionTask conditionTask in honamiStoryAreaTaskInfoUpdateNotify.ConditionTasks)
			{
				HonamiStorySubQuestData subQuestTaskData = activityData.GetSubQuestTaskData(conditionTask.Id);
				if (subQuestTaskData != null && subQuestTaskData.IsFinished())
				{
					UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestFinishView, subQuestTaskData, null);
					HonamiStoryModel.Instance.InitSubQuestTrack();
				}
			}
		}

		// Token: 0x0602EEE1 RID: 192225 RVA: 0x00D19284 File Offset: 0x00D17484
		[NullableContext(2)]
		private void OnHonamiStoryRoleUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryRoleUpdateNotify honamiStoryRoleUpdateNotify = (HonamiStoryRoleUpdateNotify)msg;
			HonamiStoryModel.Instance.GetPlayerBackpackData().RefreshRoleInfo(honamiStoryRoleUpdateNotify.RoleId);
		}

		// Token: 0x0602EEE2 RID: 192226 RVA: 0x00D192B0 File Offset: 0x00D174B0
		[NullableContext(2)]
		private void OnHonamiStoryLifeSupportNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryLifeSupportNotify honamiStoryLifeSupportNotify = (HonamiStoryLifeSupportNotify)msg;
			HonamiStoryModel.Instance.GetPlayerData().SetLifeSupportLevel(honamiStoryLifeSupportNotify.LifeSupportLevel);
			EventSystem.Instance.Emit(EEventName.OnHonamiStoryLifeSupportLevelUp);
		}

		// Token: 0x0602EEE3 RID: 192227 RVA: 0x00D192EC File Offset: 0x00D174EC
		[NullableContext(2)]
		private void OnHonamiStoryTopInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryTopInfoNotify honamiStoryTopInfoNotify = (HonamiStoryTopInfoNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).RefreshTowerData(honamiStoryTopInfoNotify.HonamiStoryTopInfos);
		}

		// Token: 0x0602EEE4 RID: 192228 RVA: 0x00D19318 File Offset: 0x00D17518
		[NullableContext(0)]
		public UniTask<bool> RequestHonamiStoryLifeSupportUp()
		{
			HonamiStoryController.<RequestHonamiStoryLifeSupportUp>d__62 <RequestHonamiStoryLifeSupportUp>d__;
			<RequestHonamiStoryLifeSupportUp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestHonamiStoryLifeSupportUp>d__.<>1__state = -1;
			<RequestHonamiStoryLifeSupportUp>d__.<>t__builder.Start<HonamiStoryController.<RequestHonamiStoryLifeSupportUp>d__62>(ref <RequestHonamiStoryLifeSupportUp>d__);
			return <RequestHonamiStoryLifeSupportUp>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEE5 RID: 192229 RVA: 0x00D19354 File Offset: 0x00D17554
		[NullableContext(0)]
		public UniTask<bool> RequestSwitchItem([Nullable(1)] HonamiStoryItemDataBase itemData, [Nullable(2)] HonamiStoryItemDataBase exchangeItemData, int position, int equipPosition, EHonamiStoryBackpack sourceBag, EHonamiStoryBackpack targetBag)
		{
			HonamiStoryController.<RequestSwitchItem>d__63 <RequestSwitchItem>d__;
			<RequestSwitchItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestSwitchItem>d__.itemData = itemData;
			<RequestSwitchItem>d__.exchangeItemData = exchangeItemData;
			<RequestSwitchItem>d__.position = position;
			<RequestSwitchItem>d__.equipPosition = equipPosition;
			<RequestSwitchItem>d__.sourceBag = sourceBag;
			<RequestSwitchItem>d__.targetBag = targetBag;
			<RequestSwitchItem>d__.<>1__state = -1;
			<RequestSwitchItem>d__.<>t__builder.Start<HonamiStoryController.<RequestSwitchItem>d__63>(ref <RequestSwitchItem>d__);
			return <RequestSwitchItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEE6 RID: 192230 RVA: 0x00D193C4 File Offset: 0x00D175C4
		[NullableContext(0)]
		public UniTask<bool> RequestSwitchInSameBag([Nullable(1)] HonamiStoryItemDataBase itemData, int position, EHonamiStoryBackpack bag)
		{
			HonamiStoryController.<RequestSwitchInSameBag>d__64 <RequestSwitchInSameBag>d__;
			<RequestSwitchInSameBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestSwitchInSameBag>d__.itemData = itemData;
			<RequestSwitchInSameBag>d__.position = position;
			<RequestSwitchInSameBag>d__.bag = bag;
			<RequestSwitchInSameBag>d__.<>1__state = -1;
			<RequestSwitchInSameBag>d__.<>t__builder.Start<HonamiStoryController.<RequestSwitchInSameBag>d__64>(ref <RequestSwitchInSameBag>d__);
			return <RequestSwitchInSameBag>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEE7 RID: 192231 RVA: 0x00D19418 File Offset: 0x00D17618
		[return: Nullable(0)]
		public UniTask<bool> RequestEquipFromPickUpBox(HonamiStoryItemDataBase itemData, HonamiStoryItemDataBase exchangeItemData, int equipPosition, int bagPosition)
		{
			HonamiStoryController.<RequestEquipFromPickUpBox>d__65 <RequestEquipFromPickUpBox>d__;
			<RequestEquipFromPickUpBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestEquipFromPickUpBox>d__.itemData = itemData;
			<RequestEquipFromPickUpBox>d__.exchangeItemData = exchangeItemData;
			<RequestEquipFromPickUpBox>d__.equipPosition = equipPosition;
			<RequestEquipFromPickUpBox>d__.bagPosition = bagPosition;
			<RequestEquipFromPickUpBox>d__.<>1__state = -1;
			<RequestEquipFromPickUpBox>d__.<>t__builder.Start<HonamiStoryController.<RequestEquipFromPickUpBox>d__65>(ref <RequestEquipFromPickUpBox>d__);
			return <RequestEquipFromPickUpBox>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEE8 RID: 192232 RVA: 0x00D19474 File Offset: 0x00D17674
		public void RequestDiscardItem(HonamiStoryItemDataBase itemData, EHonamiStoryBackpack sourceBag)
		{
			HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
			honamiStoryBagUpdateContext.BackPackConfigId = (int)sourceBag;
			HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(itemData);
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
			this.SendHonamiStoryDiscardItemRequest(honamiStoryBagUpdateContext);
		}

		// Token: 0x0602EEE9 RID: 192233 RVA: 0x00D194A8 File Offset: 0x00D176A8
		[NullableContext(0)]
		public UniTask<bool> RequestHonamiStorySellItem([Nullable(1)] List<IHonamiStoryItemSellInfo> itemInfoList)
		{
			HonamiStoryController.<RequestHonamiStorySellItem>d__67 <RequestHonamiStorySellItem>d__;
			<RequestHonamiStorySellItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestHonamiStorySellItem>d__.itemInfoList = itemInfoList;
			<RequestHonamiStorySellItem>d__.<>1__state = -1;
			<RequestHonamiStorySellItem>d__.<>t__builder.Start<HonamiStoryController.<RequestHonamiStorySellItem>d__67>(ref <RequestHonamiStorySellItem>d__);
			return <RequestHonamiStorySellItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEEA RID: 192234 RVA: 0x00D194EC File Offset: 0x00D176EC
		[NullableContext(0)]
		public UniTask<bool> RequestHonamiStoryLockItem(int itemUid, EHonamiStoryBackpack backType, bool isLock)
		{
			HonamiStoryController.<RequestHonamiStoryLockItem>d__68 <RequestHonamiStoryLockItem>d__;
			<RequestHonamiStoryLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestHonamiStoryLockItem>d__.itemUid = itemUid;
			<RequestHonamiStoryLockItem>d__.backType = backType;
			<RequestHonamiStoryLockItem>d__.isLock = isLock;
			<RequestHonamiStoryLockItem>d__.<>1__state = -1;
			<RequestHonamiStoryLockItem>d__.<>t__builder.Start<HonamiStoryController.<RequestHonamiStoryLockItem>d__68>(ref <RequestHonamiStoryLockItem>d__);
			return <RequestHonamiStoryLockItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602EEEB RID: 192235 RVA: 0x00D19540 File Offset: 0x00D17740
		private void OpenHonamiWeaponRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(1009, EUiViewName.HonamiWeaponRewardView, rewardItemDataList, null, null, null, null, null, true, false);
			if (rewardData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.HonamiWeaponRewardView, rewardData, null);
		}

		// Token: 0x17005EAE RID: 24238
		// (get) Token: 0x0602EEEC RID: 192236 RVA: 0x00D1957F File Offset: 0x00D1777F
		public static HonamiStoryController Instance
		{
			get
			{
				return HonamiStoryController._Instance;
			}
		}

		// Token: 0x0602EEED RID: 192237 RVA: 0x00D19586 File Offset: 0x00D17786
		public static HonamiStoryController GetOrCreateInstance()
		{
			if (HonamiStoryController._Instance == null)
			{
				HonamiStoryController.CreateInstance();
			}
			return HonamiStoryController._Instance;
		}

		// Token: 0x0602EEEE RID: 192238 RVA: 0x00D1959A File Offset: 0x00D1779A
		public static bool CreateInstance()
		{
			if (HonamiStoryController._Instance != null)
			{
				return true;
			}
			HonamiStoryController._Instance = new HonamiStoryController();
			return true;
		}

		// Token: 0x0602EEEF RID: 192239 RVA: 0x00D195B0 File Offset: 0x00D177B0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EEF0 RID: 192240 RVA: 0x00D195B2 File Offset: 0x00D177B2
		public static void ResetStaticDefaultValue()
		{
			HonamiStoryController._Instance = null;
		}

		// Token: 0x0602EEF1 RID: 192241 RVA: 0x00D195BA File Offset: 0x00D177BA
		static HonamiStoryController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryController.CreateStaticDefaultValue), new Action(HonamiStoryController.ResetStaticDefaultValue));
		}

		// Token: 0x04018E1D RID: 101917
		[Nullable(2)]
		private static HonamiStoryController _Instance;
	}
}
