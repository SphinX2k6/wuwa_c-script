using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A0 RID: 20896
	public static class IEntityMatchPlayerVerify
	{
		// Token: 0x06021CFC RID: 138492 RVA: 0x004B0C64 File Offset: 0x004AEE64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
