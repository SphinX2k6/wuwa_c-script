using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048C2 RID: 18626
	public class FightPhotoExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC2C RID: 191532 RVA: 0x00D0A7B4 File Offset: 0x00D089B4
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 42;
		}

		// Token: 0x0602EC2D RID: 191533 RVA: 0x00D0A808 File Offset: 0x00D08A08
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			FightPhotoExitHandler.<>c__DisplayClass1_0 CS$<>8__locals1 = new FightPhotoExitHandler.<>c__DisplayClass1_0();
			CS$<>8__locals1.data = data;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(FightPhotoController.Instance.GetActivityData().GetCurrentLevelData(true).IsFinished ? EConfirmBoxConfigId.FinishFightPhotoLeaveInstanceConfirm : EConfirmBoxConfigId.UnFinishFightPhotoLeaveInstanceConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
			int key = 0;
			InstanceDungeonExitHandlerData data2 = CS$<>8__locals1.data;
			functionMap[key] = ((data2 != null) ? data2.CancelBack : null);
			Dictionary<int, Action> functionMap2 = confirmBoxDataNew.FunctionMap;
			int key2 = 1;
			InstanceDungeonExitHandlerData data3 = CS$<>8__locals1.data;
			functionMap2[key2] = ((data3 != null) ? data3.CancelBack : null);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleExit>g__Leave|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}
}
