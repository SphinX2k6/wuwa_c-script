using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003F9F RID: 16287
	public static class ICheckpointDisplay_UnionVerify
	{
		// Token: 0x0601631F RID: 90911 RVA: 0x0032E848 File Offset: 0x0032CA48
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckpointDisplayRoleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckpointDisplayVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
