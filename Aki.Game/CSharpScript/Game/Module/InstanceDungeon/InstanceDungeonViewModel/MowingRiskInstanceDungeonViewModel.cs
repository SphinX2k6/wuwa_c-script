using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x02004868 RID: 18536
	public class MowingRiskInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x0602EA4B RID: 191051 RVA: 0x00D050A4 File Offset: 0x00D032A4
		protected override bool OnCheckInstanceUnlock(int instanceId)
		{
			return ActivityMowingRiskController.Instance.CheckInstanceUnlockByInstanceId(instanceId);
		}

		// Token: 0x0602EA4C RID: 191052 RVA: 0x00D050B4 File Offset: 0x00D032B4
		[NullableContext(2)]
		protected override TableTextArgNew OnGetUnlockConditionTextId(int instanceId)
		{
			string instanceLockTextIdByInstanceId = ActivityMowingRiskController.Instance.GetInstanceLockTextIdByInstanceId(instanceId);
			string[] args = ActivityMowingRiskController.Instance.GetInstanceLockTextArgsByInstanceId(instanceId) ?? Array.Empty<string>();
			return new TableTextArgNew(instanceLockTextIdByInstanceId, args);
		}
	}
}
