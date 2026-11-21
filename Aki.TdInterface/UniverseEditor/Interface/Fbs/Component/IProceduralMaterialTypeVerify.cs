using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D93 RID: 23955
	public static class IProceduralMaterialTypeVerify
	{
		// Token: 0x06027E58 RID: 163416 RVA: 0x00574F2A File Offset: 0x0057312A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
