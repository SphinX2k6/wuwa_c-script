using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005852 RID: 22610
	public static class IFrequencyPaintLineBaseVerify
	{
		// Token: 0x06024A22 RID: 150050 RVA: 0x0050879A File Offset: 0x0050699A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
