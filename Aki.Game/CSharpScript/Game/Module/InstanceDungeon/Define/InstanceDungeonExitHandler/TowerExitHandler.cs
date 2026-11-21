using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D5 RID: 18645
	public class TowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC68 RID: 191592 RVA: 0x00D0B55D File Offset: 0x00D0975D
		public override bool Checker()
		{
			return TowerModel.Instance.CheckInTower();
		}

		// Token: 0x0602EC69 RID: 191593 RVA: 0x00D0B56C File Offset: 0x00D0976C
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			TowerExitHandler.<>c__DisplayClass1_0 CS$<>8__locals1 = new TowerExitHandler.<>c__DisplayClass1_0();
			CS$<>8__locals1.data = data;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TowerLeave);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = new Action(CS$<>8__locals1.<HandleExit>g__Leave|1);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleExit>g__ReChallenge|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}
}
