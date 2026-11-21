using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B1 RID: 25265
	public static class TPatrolPositionRefreshTriggerVerify
	{
		// Token: 0x0602AF62 RID: 175970 RVA: 0x005DC5AC File Offset: 0x005DA7AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPatrolPositionRefreshOnEntityVisibilityShownVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPatrolPositionRefreshOnEntityAwakeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
