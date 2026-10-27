using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006444 RID: 25668
	public static class ICloseUiGameVerify
	{
		// Token: 0x0602C6D1 RID: 181969 RVA: 0x0061837E File Offset: 0x0061657E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
