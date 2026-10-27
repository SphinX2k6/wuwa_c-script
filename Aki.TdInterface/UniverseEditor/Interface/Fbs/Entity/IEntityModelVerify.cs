using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B3 RID: 18355
	public static class IEntityModelVerify
	{
		// Token: 0x0601C552 RID: 116050 RVA: 0x004029B0 File Offset: 0x00400BB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
