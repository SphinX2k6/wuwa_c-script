using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058FC RID: 22780
	public class TowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D42 RID: 236866 RVA: 0x00DBC591 File Offset: 0x00DBA791
		public override bool Checker()
		{
			return TowerModel.Instance.CheckInTower();
		}

		// Token: 0x06039D43 RID: 236867 RVA: 0x00DBC5A0 File Offset: 0x00DBA7A0
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
