using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC2 RID: 23746
	public static class IPasserbyNpcSpawnCenterPosBaseVerify
	{
		// Token: 0x0602766E RID: 161390 RVA: 0x005647E6 File Offset: 0x005629E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
