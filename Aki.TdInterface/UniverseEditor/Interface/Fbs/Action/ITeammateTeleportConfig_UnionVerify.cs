using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B50 RID: 31568
	public static class ITeammateTeleportConfig_UnionVerify
	{
		// Token: 0x06038D96 RID: 232854 RVA: 0x007AFB88 File Offset: 0x007ADD88
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
