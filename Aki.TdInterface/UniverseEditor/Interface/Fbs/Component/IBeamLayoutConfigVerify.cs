using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005438 RID: 21560
	public static class IBeamLayoutConfigVerify
	{
		// Token: 0x06021D03 RID: 138499 RVA: 0x004A962E File Offset: 0x004A782E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
