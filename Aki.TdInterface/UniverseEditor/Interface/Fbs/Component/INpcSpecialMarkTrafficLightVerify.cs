using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF6 RID: 23542
	public static class INpcSpecialMarkTrafficLightVerify
	{
		// Token: 0x06026E09 RID: 159241 RVA: 0x0055268E File Offset: 0x0055088E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
