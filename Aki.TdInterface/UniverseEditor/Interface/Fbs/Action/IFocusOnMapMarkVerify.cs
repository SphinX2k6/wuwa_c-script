using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006845 RID: 26693
	public static class IFocusOnMapMarkVerify
	{
		// Token: 0x0602E8AC RID: 190636 RVA: 0x00659A0A File Offset: 0x00657C0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
