using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736F RID: 29551
	public static class ITeammateTeleportConfig_UnionVerify
	{
		// Token: 0x06035A1D RID: 219677 RVA: 0x0074D94C File Offset: 0x0074BB4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITelePortAfterTimeOutVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITeammateTeleportConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
