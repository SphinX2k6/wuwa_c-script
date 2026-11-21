using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C7B RID: 23675
	public class LevelEventClaimDungeonReward : LevelEventBase
	{
		// Token: 0x0603A1A5 RID: 237989 RVA: 0x01060219 File Offset: 0x0105E419
		public LevelEventClaimDungeonReward(int id) : base(id)
		{
		}

		// Token: 0x0603A1A6 RID: 237990 RVA: 0x01060224 File Offset: 0x0105E424
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			int? costPower = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(instanceId);
			if (costPower != null)
			{
				int? costPower2 = costPower;
				int num = 0;
				if (!(costPower2.GetValueOrDefault() <= num & costPower2 != null))
				{
					if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanReward(instanceId))
					{
						ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonRewardTimeNotEnough", Array.Empty<object>());
						return;
					}
					bool powerEnough = PowerModel.Instance.IsPowerEnough(costPower);
					if (!powerEnough)
					{
						string textById = TextConfig.Instance.GetTextById("ReceiveLevelPlayPowerNotEnough");
						ScrollingTipsController.Instance.ShowTipsByText(textById);
						PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, costPower.Value);
						return;
					}
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ReceiveLevelPlayReward);
					confirmBoxDataNew.ShowPowerItem = true;
					confirmBoxDataNew.SetTextArgs(new string[]
					{
						costPower.ToString()
					});
					confirmBoxDataNew.FunctionMap[2] = delegate()
					{
						if (!powerEnough)
						{
							string textById2 = TextConfig.Instance.GetTextById("ReceiveLevelPlayPowerNotEnough");
							ScrollingTipsController.Instance.ShowTipsByText(textById2);
							PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, costPower.Value);
							return;
						}
						InstanceDungeonController.Instance.GetInstExchangeRewardRequest(1);
					};
					ActivityDoubleRewardData dungeonUpActivity = ActivityDoubleRewardController.Instance.GetDungeonUpActivity(InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.CustomTypes(), true);
					if (dungeonUpActivity != null && dungeonUpActivity.LeftUpCount > 0)
					{
						confirmBoxDataNew.Tip = dungeonUpActivity.GetFullTip();
					}
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
			}
		}
	}
}
