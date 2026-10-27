using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058EA RID: 22762
	public class FightPhotoExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D09 RID: 236809 RVA: 0x00DBB85C File Offset: 0x00DB9A5C
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

		// Token: 0x06039D0A RID: 236810 RVA: 0x00DBB8B0 File Offset: 0x00DB9AB0
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
