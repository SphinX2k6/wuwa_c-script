using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005926 RID: 22822
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryController : ActivityControllerBase
	{
		// Token: 0x06039F83 RID: 237443 RVA: 0x00DC82A9 File Offset: 0x00DC64A9
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.HonamiStoryUnlockTipView, null, null);
		}

		// Token: 0x06039F84 RID: 237444 RVA: 0x00DC82BC File Offset: 0x00DC64BC
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06039F85 RID: 237445 RVA: 0x00DC82BE File Offset: 0x00DC64BE
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityHonamiStoryGuide";
		}

		// Token: 0x06039F86 RID: 237446 RVA: 0x00DC82C5 File Offset: 0x00DC64C5
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new HonamiStoryActivityView();
		}

		// Token: 0x06039F87 RID: 237447 RVA: 0x00DC82CC File Offset: 0x00DC64CC
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			HonamiStoryActivityData honamiStoryActivityData = new HonamiStoryActivityData();
			HonamiStoryModel.Instance.SetActivityData(honamiStoryActivityData);
			return honamiStoryActivityData;
		}

		// Token: 0x06039F88 RID: 237448 RVA: 0x00DC82EB File Offset: 0x00DC64EB
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06039F89 RID: 237449 RVA: 0x00DC82F4 File Offset: 0x00DC64F4
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
			EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnEnterDungeon));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
		}

		// Token: 0x06039F8A RID: 237450 RVA: 0x00DC8390 File Offset: 0x00DC6590
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
			EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnEnterDungeon));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.ActivityInfoRequest));
		}

		// Token: 0x06039F8B RID: 237451 RVA: 0x00DC842C File Offset: 0x00DC662C
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

		// Token: 0x06039F8C RID: 237452 RVA: 0x00DC86A4 File Offset: 0x00DC68A4
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

		// Token: 0x06039F8D RID: 237453 RVA: 0x00DC8804 File Offset: 0x00DC6A04
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

		// Token: 0x06039F8E RID: 237454 RVA: 0x00DC88B0 File Offset: 0x00DC6AB0
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

		// Token: 0x06039F8F RID: 237455 RVA: 0x00DC8918 File Offset: 0x00DC6B18
		[NullableContext(0)]
		public UniTask<bool> OpenHonamiStoryBag()
		{
			HonamiStoryController.<OpenHonamiStoryBag>d__12 <OpenHonamiStoryBag>d__;
			<OpenHonamiStoryBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenHonamiStoryBag>d__.<>1__state = -1;
			<OpenHonamiStoryBag>d__.<>t__builder.Start<HonamiStoryController.<OpenHonamiStoryBag>d__12>(ref <OpenHonamiStoryBag>d__);
			return <OpenHonamiStoryBag>d__.<>t__builder.Task;
		}

		// Token: 0x06039F90 RID: 237456 RVA: 0x00DC8954 File Offset: 0x00DC6B54
		public void SetHonamiStoryLoadingInfoByResult(bool isSuccess)
		{
			EHonamiStoryLoadingTimingType honamiStoryLoadingInfoByTimingOnly = isSuccess ? EHonamiStoryLoadingTimingType.SuccessLeave : EHonamiStoryLoadingTimingType.FailLeave;
			this.SetHonamiStoryLoadingInfoByTimingOnly(honamiStoryLoadingInfoByTimingOnly);
		}

		// Token: 0x06039F91 RID: 237457 RVA: 0x00DC8970 File Offset: 0x00DC6B70
		public void SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType timing)
		{
			HonamiStoryLoadingDataImpl gamePlayLoadingData = new HonamiStoryLoadingDataImpl
			{
				Timing = new int?((int)timing)
			};
			HonamiStoryModel.Instance.SetGamePlayLoadingData(gamePlayLoadingData);
		}

		// Token: 0x06039F92 RID: 237458 RVA: 0x00DC899C File Offset: 0x00DC6B9C
		public void SetHonamiStoryLoadingInfoByBtId(int btId)
		{
			HonamiStoryLoadingDataImpl gamePlayLoadingData = new HonamiStoryLoadingDataImpl
			{
				Timing = new int?(2),
				BtId = new int?(btId)
			};
			HonamiStoryModel.Instance.SetGamePlayLoadingData(gamePlayLoadingData);
		}

		// Token: 0x06039F93 RID: 237459 RVA: 0x00DC89D4 File Offset: 0x00DC6BD4
		[NullableContext(2)]
		public void OnHonamiStoryInstInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryInstInfoNotify honamiStoryInstInfoNotify = (HonamiStoryInstInfoNotify)msg;
			HonamiStoryModel.Instance.SetIsLastPickUpViewDirty(false);
			HonamiStoryModel.Instance.InitBackPackInfoList(honamiStoryInstInfoNotify.HonamiStoryBagInfos.ToList<HonamiStoryBagInfo>());
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

		// Token: 0x06039F94 RID: 237460 RVA: 0x00DC8CBC File Offset: 0x00DC6EBC
		[NullableContext(2)]
		private void OnHonamiStorySafeLeaveNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStorySafeLeaveNotify honamiStorySafeLeaveNotify = (HonamiStorySafeLeaveNotify)msg;
			this.UpdateHonamiStorySafeLeave(honamiStorySafeLeaveNotify.CanSafeLeave, true);
		}

		// Token: 0x06039F95 RID: 237461 RVA: 0x00DC8CDD File Offset: 0x00DC6EDD
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

		// Token: 0x06039F96 RID: 237462 RVA: 0x00DC8D19 File Offset: 0x00DC6F19
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

		// Token: 0x06039F97 RID: 237463 RVA: 0x00DC8D54 File Offset: 0x00DC6F54
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

		// Token: 0x06039F98 RID: 237464 RVA: 0x00DC8E30 File Offset: 0x00DC7030
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

		// Token: 0x06039F99 RID: 237465 RVA: 0x00DC8FF0 File Offset: 0x00DC71F0
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
				DescriptionArgs = (needCost ? list2.Cast<object>().ToList<object>() : null),
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
								InstanceDungeonEntranceController.Instance.RestartInstanceDungeon();
							});
						}
						functionMap.Add(key, value);
						ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
						return;
					}
					this.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.Tower);
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon();
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

		// Token: 0x06039F9A RID: 237466 RVA: 0x00DC93F0 File Offset: 0x00DC75F0
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

		// Token: 0x06039F9B RID: 237467 RVA: 0x00DC9450 File Offset: 0x00DC7650
		private void OnEnterDungeon(int _1, int _2)
		{
			if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
			{
				FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.HonamiStoryLifeSupport, new TValueListener(this.OnHonamiStoryLifeSupportChanged), null);
			}
		}

		// Token: 0x06039F9C RID: 237468 RVA: 0x00DC9474 File Offset: 0x00DC7674
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

		// Token: 0x06039F9D RID: 237469 RVA: 0x00DC94C3 File Offset: 0x00DC76C3
		private void OnHonamiStoryLifeSupportChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<float, float>(EEventName.OnHonamiStoryLifeSupportChanged, oldValue, newValue);
		}

		// Token: 0x06039F9E RID: 237470 RVA: 0x00DC94D8 File Offset: 0x00DC76D8
		[NullableContext(2)]
		private void OnHonamiStoryMascotInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryMascotInfoUpdateNotify honamiStoryMascotInfoUpdateNotify = (HonamiStoryMascotInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).UpdateHonamiStoryMascotDataList(honamiStoryMascotInfoUpdateNotify.HonamiStoryMascotInfos.ToList<HonamiStoryMascotInfo>());
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

		// Token: 0x06039F9F RID: 237471 RVA: 0x00DC9578 File Offset: 0x00DC7778
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryMascotRewardResponse.ErrorCode, 25929, null, true, true);
					return;
				}
				HonamiStoryModel.Instance.GetActivityData(true).GetHonamiStoryMascotData(mascotId).UpdateState(EHonamiStoryCollectState.GotReward);
				EventSystem.Instance.Emit<int>(EEventName.OnHonamiStoryMascotRewardReceive, mascotId);
				callback();
			}, 0);
		}

		// Token: 0x06039FA0 RID: 237472 RVA: 0x00DC95C8 File Offset: 0x00DC77C8
		[NullableContext(2)]
		private void OnHonamiStoryAreaInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAreaInfoUpdateNotify honamiStoryAreaInfoUpdateNotify = (HonamiStoryAreaInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).UpdateHonamiStoryAreaDataList(honamiStoryAreaInfoUpdateNotify.HonamiStoryAreaInfo.ToList<HonamiStoryAreaInfo>());
		}

		// Token: 0x06039FA1 RID: 237473 RVA: 0x00DC95F8 File Offset: 0x00DC77F8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryAreaSecretRewardResponse.ErrorCode, 26290, null, true, true);
					return;
				}
				HonamiStoryModel.Instance.GetActivityData(true).GetHonamiStoryAreaData(areaSecretId).UpdateCollectMascotState(EHonamiStoryCollectState.GotReward);
				EventSystem.Instance.Emit<int>(EEventName.OnHonamiStoryAreaSecretRewardReceive, areaSecretId);
				callback();
			}, 0);
		}

		// Token: 0x06039FA2 RID: 237474 RVA: 0x00DC9648 File Offset: 0x00DC7848
		[NullableContext(0)]
		public UniTask<bool> LeaveHonamiDungeon()
		{
			HonamiStoryController.<LeaveHonamiDungeon>d__31 <LeaveHonamiDungeon>d__;
			<LeaveHonamiDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LeaveHonamiDungeon>d__.<>1__state = -1;
			<LeaveHonamiDungeon>d__.<>t__builder.Start<HonamiStoryController.<LeaveHonamiDungeon>d__31>(ref <LeaveHonamiDungeon>d__);
			return <LeaveHonamiDungeon>d__.<>t__builder.Task;
		}

		// Token: 0x06039FA3 RID: 237475 RVA: 0x00DC9683 File Offset: 0x00DC7883
		public bool CanOpenBackpack(EUiViewName viewName, object _)
		{
			return FunctionModel.Instance.IsOpen(10102);
		}

		// Token: 0x06039FA4 RID: 237476 RVA: 0x00DC9694 File Offset: 0x00DC7894
		[NullableContext(2)]
		private void OnHonamiStorySetFormationNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStorySetFormationNotify honamiStorySetFormationNotify = (HonamiStorySetFormationNotify)msg;
			HonamiStoryPlayerBackpackData playerBackpackData = HonamiStoryModel.Instance.GetPlayerBackpackData();
			playerBackpackData.RefreshEquipInfo(honamiStorySetFormationNotify.HonamiStoryRackInfos.ToList<HonamiStoryRackInfo>());
			if (honamiStorySetFormationNotify.EquipRack != null)
			{
				playerBackpackData.RefreshGridItemInfo(honamiStorySetFormationNotify.EquipRack.HonamiStoryBagItemInfos.ToList<HonamiStoryBagItemInfo>());
			}
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
		}

		// Token: 0x06039FA5 RID: 237477 RVA: 0x00DC96F0 File Offset: 0x00DC78F0
		[NullableContext(2)]
		private void OnHonamiStoryBagInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryBagInfoUpdateNotify updateInfo = (HonamiStoryBagInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.UpdateBackpackInfo(updateInfo);
			HonamiStoryModel.Instance.SetQuickAllDirty(true);
		}

		// Token: 0x06039FA6 RID: 237478 RVA: 0x00DC971C File Offset: 0x00DC791C
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

		// Token: 0x06039FA7 RID: 237479 RVA: 0x00DC9760 File Offset: 0x00DC7960
		public void RequestHonamiStoryEquipRole(List<int> roleList)
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryEquipRoleResponse.ErrorCode, 28938, null, true, true);
					return;
				}
				RepeatedField<int> roleId = honamiStoryEquipRoleResponse.RoleId;
				HonamiStoryModel.Instance.UpdateRoleList(roleId.ToList<int>());
				EventSystem.Instance.Emit(EEventName.OnHonamiStoryRoleEquipChanged);
				HonamiStoryModel.Instance.SetQuickAllDirty(true);
			}, 0);
		}

		// Token: 0x06039FA8 RID: 237480 RVA: 0x00DC97C0 File Offset: 0x00DC79C0
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

		// Token: 0x06039FA9 RID: 237481 RVA: 0x00DC9814 File Offset: 0x00DC7A14
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

		// Token: 0x06039FAA RID: 237482 RVA: 0x00DC9860 File Offset: 0x00DC7A60
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryDiscardItemResponse.ErrorCode, 24394, null, true, true);
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

		// Token: 0x06039FAB RID: 237483 RVA: 0x00DC98B8 File Offset: 0x00DC7AB8
		[NullableContext(2)]
		private void OnHonamiStoryBagSizeUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			MapField<int, int> bagSize = ((HonamiStoryBagSizeUpdateNotify)msg).BagSize;
			HonamiStoryModel.Instance.UpdateBackpackSize(bagSize.ToDictionary<int, int>());
		}

		// Token: 0x06039FAC RID: 237484 RVA: 0x00DC98E4 File Offset: 0x00DC7AE4
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

		// Token: 0x06039FAD RID: 237485 RVA: 0x00DC9930 File Offset: 0x00DC7B30
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

		// Token: 0x06039FAE RID: 237486 RVA: 0x00DC9984 File Offset: 0x00DC7B84
		[NullableContext(2)]
		private void OnHonamiStoryPermanentTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryResidentTaskInfoUpdateNotify honamiStoryResidentTaskInfoUpdateNotify = (HonamiStoryResidentTaskInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdatePermanentTaskDataList(honamiStoryResidentTaskInfoUpdateNotify.ConditionTasks.ToList<ConditionTask>());
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}

		// Token: 0x06039FAF RID: 237487 RVA: 0x00DC99CC File Offset: 0x00DC7BCC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryResidentTaskRewardResponse.ErrorCode, 19821, null, true, true);
					return;
				}
				foreach (int id in taskIds)
				{
					activityData.GetPermanentTaskData(id).UpdateState(EActivityTaskState.FinishedAndClaimed);
				}
				callback();
			}, 0);
		}

		// Token: 0x06039FB0 RID: 237488 RVA: 0x00DC9A44 File Offset: 0x00DC7C44
		[NullableContext(2)]
		private void OnHonamiStoryLimitTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryLimitTaskInfoUpdateNotify honamiStoryLimitTaskInfoUpdateNotify = (HonamiStoryLimitTaskInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdateLimitTaskDataList(honamiStoryLimitTaskInfoUpdateNotify.ConditionTasks.ToList<ConditionTask>());
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}

		// Token: 0x06039FB1 RID: 237489 RVA: 0x00DC9A8C File Offset: 0x00DC7C8C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryLimitTaskRewardResponse.ErrorCode, 27065, null, true, true);
					return;
				}
				foreach (int id in taskIds)
				{
					activityData.GetLimitTaskData(id).UpdateState(EActivityTaskState.FinishedAndClaimed);
				}
				callback();
			}, 0);
		}

		// Token: 0x06039FB2 RID: 237490 RVA: 0x00DC9B04 File Offset: 0x00DC7D04
		[NullableContext(2)]
		public void OnHonamiStoryScoreRewardInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryScoreRewardInfoUpdateNotify honamiStoryScoreRewardInfoUpdateNotify = (HonamiStoryScoreRewardInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdateScoreRewardDataList(honamiStoryScoreRewardInfoUpdateNotify.HonamiStoryScoreRewardInfos.ToList<HonamiStoryScoreRewardInfo>());
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}

		// Token: 0x06039FB3 RID: 237491 RVA: 0x00DC9B4C File Offset: 0x00DC7D4C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryScoreRewardResponse.ErrorCode, 26582, null, true, true);
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

		// Token: 0x06039FB4 RID: 237492 RVA: 0x00DC9BBC File Offset: 0x00DC7DBC
		[NullableContext(2)]
		private void OnHonamiStoryAddWeaponNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAddWeaponNotify honamiStoryAddWeaponNotify = (HonamiStoryAddWeaponNotify)msg;
			HonamiStoryModel.Instance.UpdateWeaponDataList(honamiStoryAddWeaponNotify.WeaponIds.ToList<int>());
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

		// Token: 0x06039FB5 RID: 237493 RVA: 0x00DC9C98 File Offset: 0x00DC7E98
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryWeaponDressResponse.ErrorCode, 29480, null, true, true);
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

		// Token: 0x06039FB6 RID: 237494 RVA: 0x00DC9CF4 File Offset: 0x00DC7EF4
		[NullableContext(2)]
		private void OnHonamiStoryItemCollectionInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryItemCollectionInfoUpdateNotify honamiStoryItemCollectionInfoUpdateNotify = (HonamiStoryItemCollectionInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).UpdateItemCollectionDataList(honamiStoryItemCollectionInfoUpdateNotify.HonamiStoryItemCollectionInfos.ToList<HonamiStoryItemCollectionInfo>());
		}

		// Token: 0x06039FB7 RID: 237495 RVA: 0x00DC9D24 File Offset: 0x00DC7F24
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
			int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
			int areaInstId = activityData.AreaInstId;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(areaInstId, allRoleIdList.ToList<int>(), 0, 0, null, null).ContinueWith(delegate(bool value)
			{
				HonamiStoryModel.Instance.SetQuickAllDirty(true);
			});
		}

		// Token: 0x06039FB8 RID: 237496 RVA: 0x00DC9DF8 File Offset: 0x00DC7FF8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryItemCollectionResponse.ErrorCode, 16494, null, true, true);
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

		// Token: 0x06039FB9 RID: 237497 RVA: 0x00DC9E5C File Offset: 0x00DC805C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(honamiStoryActivateTalentResponse.ErrorCode, 28751, null, true, true);
					return;
				}
				callback();
			}, 0);
		}

		// Token: 0x06039FBA RID: 237498 RVA: 0x00DC9EA0 File Offset: 0x00DC80A0
		[NullableContext(2)]
		private void OnHonamiStoryTalentInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryTalentInfoUpdateNotify honamiStoryTalentInfoUpdateNotify = (HonamiStoryTalentInfoUpdateNotify)msg;
			HonamiStoryModel.Instance.RefreshTalentInfos(honamiStoryTalentInfoUpdateNotify.HonamiStoryTalentInfos);
			EventSystem.Instance.Emit(EEventName.OnHonamiStoryTechNodeLevelUpdate);
		}

		// Token: 0x06039FBB RID: 237499 RVA: 0x00DC9ED4 File Offset: 0x00DC80D4
		[NullableContext(2)]
		private void OnHonamiStoryTotalRevenueNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryTotalRevenueNotify honamiStoryTotalRevenueNotify = (HonamiStoryTotalRevenueNotify)msg;
			HonamiStoryModel.Instance.SetTotalRevenueInternal(honamiStoryTotalRevenueNotify.TotalRevenue);
		}

		// Token: 0x06039FBC RID: 237500 RVA: 0x00DC9EF8 File Offset: 0x00DC80F8
		[NullableContext(2)]
		private void OnHonamiStoryAreaTaskInfoRefreshNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAreaTaskInfoRefreshNotify honamiStoryAreaTaskInfoRefreshNotify = (HonamiStoryAreaTaskInfoRefreshNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).InitSubQuestTaskDataList(honamiStoryAreaTaskInfoRefreshNotify.ConditionTasks);
		}

		// Token: 0x06039FBD RID: 237501 RVA: 0x00DC9F24 File Offset: 0x00DC8124
		[NullableContext(2)]
		private void OnHonamiStoryAreaTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryAreaTaskInfoUpdateNotify honamiStoryAreaTaskInfoUpdateNotify = (HonamiStoryAreaTaskInfoUpdateNotify)msg;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			activityData.UpdateSubQuestTaskDataList(honamiStoryAreaTaskInfoUpdateNotify.ConditionTasks.ToList<ConditionTask>());
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

		// Token: 0x06039FBE RID: 237502 RVA: 0x00DC9FC8 File Offset: 0x00DC81C8
		[NullableContext(2)]
		private void OnHonamiStoryRoleUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryRoleUpdateNotify honamiStoryRoleUpdateNotify = (HonamiStoryRoleUpdateNotify)msg;
			HonamiStoryModel.Instance.GetPlayerBackpackData().RefreshRoleInfo(honamiStoryRoleUpdateNotify.RoleId.ToList<int>());
		}

		// Token: 0x06039FBF RID: 237503 RVA: 0x00DC9FF8 File Offset: 0x00DC81F8
		[NullableContext(2)]
		private void OnHonamiStoryLifeSupportNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryLifeSupportNotify honamiStoryLifeSupportNotify = (HonamiStoryLifeSupportNotify)msg;
			HonamiStoryModel.Instance.GetPlayerData().SetLifeSupportLevel(honamiStoryLifeSupportNotify.LifeSupportLevel);
			EventSystem.Instance.Emit(EEventName.OnHonamiStoryLifeSupportLevelUp);
		}

		// Token: 0x06039FC0 RID: 237504 RVA: 0x00DCA034 File Offset: 0x00DC8234
		[NullableContext(2)]
		private void OnHonamiStoryTopInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			HonamiStoryTopInfoNotify honamiStoryTopInfoNotify = (HonamiStoryTopInfoNotify)msg;
			HonamiStoryModel.Instance.GetActivityData(true).RefreshTowerData(honamiStoryTopInfoNotify.HonamiStoryTopInfos.ToList<HonamiStoryTopInfo>());
		}

		// Token: 0x06039FC1 RID: 237505 RVA: 0x00DCA064 File Offset: 0x00DC8264
		[NullableContext(0)]
		public UniTask<bool> RequestHonamiStoryLifeSupportUp()
		{
			HonamiStoryController.<RequestHonamiStoryLifeSupportUp>d__62 <RequestHonamiStoryLifeSupportUp>d__;
			<RequestHonamiStoryLifeSupportUp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestHonamiStoryLifeSupportUp>d__.<>1__state = -1;
			<RequestHonamiStoryLifeSupportUp>d__.<>t__builder.Start<HonamiStoryController.<RequestHonamiStoryLifeSupportUp>d__62>(ref <RequestHonamiStoryLifeSupportUp>d__);
			return <RequestHonamiStoryLifeSupportUp>d__.<>t__builder.Task;
		}

		// Token: 0x06039FC2 RID: 237506 RVA: 0x00DCA0A0 File Offset: 0x00DC82A0
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

		// Token: 0x06039FC3 RID: 237507 RVA: 0x00DCA110 File Offset: 0x00DC8310
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

		// Token: 0x06039FC4 RID: 237508 RVA: 0x00DCA164 File Offset: 0x00DC8364
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

		// Token: 0x06039FC5 RID: 237509 RVA: 0x00DCA1C0 File Offset: 0x00DC83C0
		public void RequestDiscardItem(HonamiStoryItemDataBase itemData, EHonamiStoryBackpack sourceBag)
		{
			HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
			honamiStoryBagUpdateContext.BackPackConfigId = (int)sourceBag;
			HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(itemData);
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
			this.SendHonamiStoryDiscardItemRequest(honamiStoryBagUpdateContext);
		}

		// Token: 0x06039FC6 RID: 237510 RVA: 0x00DCA1F4 File Offset: 0x00DC83F4
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

		// Token: 0x06039FC7 RID: 237511 RVA: 0x00DCA238 File Offset: 0x00DC8438
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

		// Token: 0x06039FC8 RID: 237512 RVA: 0x00DCA28C File Offset: 0x00DC848C
		private void OpenHonamiWeaponRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(1009, EUiViewName.HonamiWeaponRewardView, rewardItemDataList, null, null, null, null, null, true, false);
			if (rewardData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.HonamiWeaponRewardView, rewardData, null);
		}

		// Token: 0x17008AE2 RID: 35554
		// (get) Token: 0x06039FC9 RID: 237513 RVA: 0x00DCA2CB File Offset: 0x00DC84CB
		public static HonamiStoryController Instance
		{
			get
			{
				return HonamiStoryController._Instance;
			}
		}

		// Token: 0x06039FCA RID: 237514 RVA: 0x00DCA2D2 File Offset: 0x00DC84D2
		public static HonamiStoryController GetOrCreateInstance()
		{
			if (HonamiStoryController._Instance == null)
			{
				HonamiStoryController.CreateInstance();
			}
			return HonamiStoryController._Instance;
		}

		// Token: 0x06039FCB RID: 237515 RVA: 0x00DCA2E6 File Offset: 0x00DC84E6
		public static bool CreateInstance()
		{
			if (HonamiStoryController._Instance != null)
			{
				return true;
			}
			HonamiStoryController._Instance = new HonamiStoryController();
			return true;
		}

		// Token: 0x06039FCC RID: 237516 RVA: 0x00DCA2FC File Offset: 0x00DC84FC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039FCD RID: 237517 RVA: 0x00DCA2FE File Offset: 0x00DC84FE
		public static void ResetStaticDefaultValue()
		{
			HonamiStoryController._Instance = null;
		}

		// Token: 0x06039FCE RID: 237518 RVA: 0x00DCA306 File Offset: 0x00DC8506
		static HonamiStoryController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryController.CreateStaticDefaultValue), new Action(HonamiStoryController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E380 RID: 123776
		[Nullable(2)]
		private static HonamiStoryController _Instance;
	}
}
