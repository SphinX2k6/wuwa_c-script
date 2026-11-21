using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005971 RID: 22897
	public static class IImmediateAddBuffVerify
	{
		// Token: 0x06025534 RID: 152884 RVA: 0x0051F96E File Offset: 0x0051DB6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
