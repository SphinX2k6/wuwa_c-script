using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB3 RID: 23731
	public static class IPasserbyNpcSelfSpawnCenterPosVerify
	{
		// Token: 0x06027612 RID: 161298 RVA: 0x00563F96 File Offset: 0x00562196
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
