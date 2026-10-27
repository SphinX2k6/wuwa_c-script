using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200488B RID: 18571
	public static class IMarbleLevelVerify
	{
		// Token: 0x0601CF9B RID: 118683 RVA: 0x004182F9 File Offset: 0x004164F9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
