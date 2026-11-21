using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D13 RID: 23827
	public static class IPatrolPositionRefresh_UnionVerify
	{
		// Token: 0x06027923 RID: 162083 RVA: 0x00569B6C File Offset: 0x00567D6C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPatrolPositionRefreshAtNearestSplinePointToPlayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPatrolPositionRefreshVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
