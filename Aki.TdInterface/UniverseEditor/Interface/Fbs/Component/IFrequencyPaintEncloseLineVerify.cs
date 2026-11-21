using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584F RID: 22607
	public static class IFrequencyPaintEncloseLineVerify
	{
		// Token: 0x06024A10 RID: 150032 RVA: 0x00508622 File Offset: 0x00506822
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
