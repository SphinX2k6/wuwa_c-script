using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A6B RID: 14955
	public static class IBvbNpcCardNumVerify
	{
		// Token: 0x06014462 RID: 83042 RVA: 0x002F60FE File Offset: 0x002F42FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
