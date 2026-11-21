using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005858 RID: 22616
	public static class IFrequencyPaintStraightLineVerify
	{
		// Token: 0x06024A46 RID: 150086 RVA: 0x00508ADA File Offset: 0x00506CDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
