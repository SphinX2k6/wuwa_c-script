using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004805 RID: 18437
	public static class IManualOccupationRefSourceVerify
	{
		// Token: 0x0601B3F0 RID: 111600 RVA: 0x003DC3BE File Offset: 0x003DA5BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
