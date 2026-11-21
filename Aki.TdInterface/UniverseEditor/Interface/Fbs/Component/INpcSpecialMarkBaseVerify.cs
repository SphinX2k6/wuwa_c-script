using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BED RID: 23533
	public static class INpcSpecialMarkBaseVerify
	{
		// Token: 0x06026DD5 RID: 159189 RVA: 0x00552212 File Offset: 0x00550412
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
