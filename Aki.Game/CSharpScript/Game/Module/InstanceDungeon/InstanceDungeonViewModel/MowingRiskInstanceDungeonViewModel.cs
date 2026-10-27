using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x02005890 RID: 22672
	public class MowingRiskInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x06039B28 RID: 236328 RVA: 0x00DB618C File Offset: 0x00DB438C
		protected override bool OnCheckInstanceUnlock(int instanceId)
		{
			return ActivityMowingRiskController.Instance.CheckInstanceUnlockByInstanceId(instanceId);
		}

		// Token: 0x06039B29 RID: 236329 RVA: 0x00DB619C File Offset: 0x00DB439C
		[NullableContext(2)]
		protected override TableTextArgNew OnGetUnlockConditionTextId(int instanceId)
		{
			string instanceLockTextIdByInstanceId = ActivityMowingRiskController.Instance.GetInstanceLockTextIdByInstanceId(instanceId);
			string[] args = ActivityMowingRiskController.Instance.GetInstanceLockTextArgsByInstanceId(instanceId) ?? Array.Empty<string>();
			return new TableTextArgNew(instanceLockTextIdByInstanceId, args);
		}
	}
}
