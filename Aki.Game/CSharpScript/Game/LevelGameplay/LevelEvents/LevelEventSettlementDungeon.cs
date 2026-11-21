using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CF8 RID: 23800
	public class LevelEventSettlementDungeon : LevelEventBase
	{
		// Token: 0x0603A3BB RID: 238523 RVA: 0x01074372 File Offset: 0x01072572
		public LevelEventSettlementDungeon(int id) : base(id)
		{
		}

		// Token: 0x0603A3BC RID: 238524 RVA: 0x0107437C File Offset: 0x0107257C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (InstanceDungeonModel.Instance.InstanceFinishSuccess != EInstanceFinishState.Success)
			{
				global::Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "副本结算行为触发时，副本未成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			int? costPower = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(instanceId);
			bool flag = costPower == null || costPower.GetValueOrDefault() == 0;
			if (flag)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			if (InstanceDungeonModel.Instance.InstanceRewardHaveTake)
			{
				ScrollingTipsController.Instance.ShowTipsById("HaveReceiveRewrad", Array.Empty<object>());
				base.FinishExecute(true, false, true);
				return;
			}
			if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
			{
				base.FinishExecute(true, false, true);
				return;
			}
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanReward(instanceId))
			{
				this.OpenInstanceRewardTimesNotEnoughConfirmBox();
				base.FinishExecute(true, false, true);
				return;
			}
			if (!ExchangeRewardModel.Instance.GetInstanceDungeonIfCanExchange(instanceId))
			{
				this.OpenInstanceRewardTimesNotEnoughConfirmBox();
				base.FinishExecute(true, false, true);
				return;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			bool flag2 = InstanceDungeonConfig.Instance.GetInstanceFirstRewardId(instanceId) != 0;
			bool? currentInstanceIsFinish = InstanceDungeonModel.Instance.CurrentInstanceIsFinish;
			if (flag2 && !currentInstanceIsFinish.GetValueOrDefault() && config.Value.InstSubType != 49)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			ActivityDoubleRewardData dungeonUpActivity = ActivityDoubleRewardController.Instance.GetDungeonUpActivity(config.Value.CustomTypes(), true);
			ValueTuple<bool, int, int, string, string> regressDoubleDropTuple = ActivityRegressModel.Instance.GetRegressDoubleDropTuple(instanceId);
			bool item = regressDoubleDropTuple.Item1;
			int item2 = regressDoubleDropTuple.Item2;
			int item3 = regressDoubleDropTuple.Item3;
			string item4 = regressDoubleDropTuple.Item4;
			string item5 = regressDoubleDropTuple.Item5;
			bool flag3 = dungeonUpActivity != null && dungeonUpActivity.LeftUpCount > 0;
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("MultiExchangeInstType");
			bool flag4 = false;
			if (intArrayConfig != null)
			{
				for (int i = 0; i < intArrayConfig.Count; i++)
				{
					if (intArrayConfig[i] == config.Value.InstSubType)
					{
						flag4 = true;
						break;
					}
				}
			}
			if (!item && FunctionModel.Instance.IsOpen(EFunctionType.PowerMagnificationReward) && flag4)
			{
				PowerMagnificationRewardPopViewData powerMagnificationRewardPopViewData = new PowerMagnificationRewardPopViewData();
				powerMagnificationRewardPopViewData.SinglePowerCost = costPower.Value;
				powerMagnificationRewardPopViewData.RewardCallBack = delegate(int count)
				{
					InstanceDungeonController.Instance.GetInstExchangeRewardRequest(count);
				};
				PowerMagnificationRewardPopViewData powerMagnificationRewardPopViewData2 = powerMagnificationRewardPopViewData;
				if (flag3)
				{
					powerMagnificationRewardPopViewData2.Tip = dungeonUpActivity.GetFullTip();
				}
				UiManager.Instance.OpenView(EUiViewName.PowerMagnificationRewardPopView, powerMagnificationRewardPopViewData2, null);
				base.FinishExecute(true, false, true);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ReceiveLevelPlayReward);
			confirmBoxDataNew.ShowPowerItem = true;
			confirmBoxDataNew.CanExecuteCloseFunc = ((int selectedIndex) => selectedIndex != 2 || PowerModel.Instance.IsPowerEnough(costPower));
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				costPower.ToString()
			});
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (!PowerModel.Instance.IsPowerEnough(costPower))
				{
					string textById = TextConfig.Instance.GetTextById("ReceiveLevelPlayPowerNotEnough");
					ScrollingTipsController.Instance.ShowTipsByText(textById);
					PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, PowerModel.Instance.GetCurrentNeedPower(costPower));
					return;
				}
				InstanceDungeonController.Instance.GetInstExchangeRewardRequest(1);
			};
			if (flag3)
			{
				confirmBoxDataNew.Tip = dungeonUpActivity.GetFullTip();
			}
			if (item)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(item5, null);
				string str = StringUtils.FormatStaticBuilder(ConfigMultiTextLang.GetLocalTextNew(item4, null), new object[]
				{
					item2,
					item3
				});
				confirmBoxDataNew.Tip = localTextNew + str;
			}
			base.FinishExecute(true, false, true);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603A3BD RID: 238525 RVA: 0x010746EC File Offset: 0x010728EC
		public void OpenInstanceRewardTimesNotEnoughConfirmBox()
		{
			LevelEventSettlementDungeon.<>c__DisplayClass2_0 CS$<>8__locals1 = new LevelEventSettlementDungeon.<>c__DisplayClass2_0();
			LevelEventSettlementDungeon.<>c__DisplayClass2_0 CS$<>8__locals2 = CS$<>8__locals1;
			GameModeModel instance = GameModeModel.Instance;
			CS$<>8__locals2.isMulti = ((instance != null) ? new bool?(instance.IsMulti) : null);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(CS$<>8__locals1.isMulti.GetValueOrDefault() ? EConfirmBoxConfigId.InstanceRewardTimesNotEnoughMulti : EConfirmBoxConfigId.InstanceRewardTimesNotEnoughSingle);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				if (!CS$<>8__locals1.isMulti.GetValueOrDefault())
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				}
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (!CS$<>8__locals1.isMulti.GetValueOrDefault())
				{
					InstanceDungeonEntranceController instance2 = InstanceDungeonEntranceController.Instance;
					bool currentRechallengeInInst = instance2.GetCurrentRechallengeInInst();
					instance2.RestartInstanceDungeon(currentRechallengeInInst);
					return;
				}
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}
}
