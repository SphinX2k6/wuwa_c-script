using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005658 RID: 22104
	public static class INpcSpecialMarkTrafficLightVerify
	{
		// Token: 0x06024BE8 RID: 150504 RVA: 0x00511D26 File Offset: 0x0050FF26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
