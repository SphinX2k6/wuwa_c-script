using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003631 RID: 13873
	[NullableContext(1)]
	public interface IGameplayEntityLinkService
	{
		// Token: 0x06024006 RID: 147462
		IReadOnlyList<int> GetLinkedGroupPbDataIds(int sourcePbDataId);

		// Token: 0x06024007 RID: 147463
		int GetLinkedGroupRootPbDataId(int sourcePbDataId);

		// Token: 0x06024008 RID: 147464
		IReadOnlyList<ActionInfo> FilterLinkedActionList(int sourcePbDataId, IReadOnlyList<ActionInfo> actionList);

		// Token: 0x06024009 RID: 147465
		void SyncLinkedEntityState(int sourcePbDataId, EGameplayEntityState targetState);

		// Token: 0x0602400A RID: 147466
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		ValueTuple<bool, IReadOnlyList<ActionInfo>>? ConsumePressureTriggerGroupChange(int sourcePbDataId);

		// Token: 0x0602400B RID: 147467
		void OnRollbackRestore();
	}
}
