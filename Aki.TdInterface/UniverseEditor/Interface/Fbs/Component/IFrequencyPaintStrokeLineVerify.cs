using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585B RID: 22619
	public static class IFrequencyPaintStrokeLineVerify
	{
		// Token: 0x06024A58 RID: 150104 RVA: 0x00508C52 File Offset: 0x00506E52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
