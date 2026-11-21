using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200457F RID: 17791
	public static class ISpecialProcessVerify
	{
		// Token: 0x06019E96 RID: 106134 RVA: 0x003B1EF2 File Offset: 0x003B00F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
