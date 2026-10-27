using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721C RID: 29212
	public static class ISubScreenModeInitVerify
	{
		// Token: 0x06033D1B RID: 212251 RVA: 0x006F94F7 File Offset: 0x006F76F7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
