using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D10 RID: 23824
	public static class IPatrolPositionRefreshTrigger_UnionVerify
	{
		// Token: 0x06027917 RID: 162071 RVA: 0x00569A5C File Offset: 0x00567C5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPatrolPositionRefreshTriggerVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPatrolPositionRefreshOnEntityAwakeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPatrolPositionRefreshOnEntityVisibilityShownVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
