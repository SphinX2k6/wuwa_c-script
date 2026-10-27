using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004701 RID: 18177
	[NullableContext(1)]
	public interface IGameplayEntityLinkService
	{
		// Token: 0x0602F840 RID: 194624
		IReadOnlyList<int> GetLinkedGroupPbDataIds(int sourcePbDataId);

		// Token: 0x0602F841 RID: 194625
		int GetLinkedGroupRootPbDataId(int sourcePbDataId);

		// Token: 0x0602F842 RID: 194626
		IReadOnlyList<ActionInfo> FilterLinkedActionList(int sourcePbDataId, IReadOnlyList<ActionInfo> actionList);

		// Token: 0x0602F843 RID: 194627
		void SyncLinkedEntityState(int sourcePbDataId, EGameplayEntityState targetState);

		// Token: 0x0602F844 RID: 194628
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		ValueTuple<bool, IReadOnlyList<ActionInfo>>? ConsumePressureTriggerGroupChange(int sourcePbDataId);

		// Token: 0x0602F845 RID: 194629
		void OnRollbackRestore();
	}
}
