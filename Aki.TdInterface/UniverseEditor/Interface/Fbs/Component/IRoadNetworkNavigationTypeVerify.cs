using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E7F RID: 24191
	public static class IRoadNetworkNavigationTypeVerify
	{
		// Token: 0x060287DB RID: 165851 RVA: 0x00589856 File Offset: 0x00587A56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
