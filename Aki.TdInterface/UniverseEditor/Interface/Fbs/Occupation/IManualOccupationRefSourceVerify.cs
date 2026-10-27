using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A3 RID: 17315
	public static class IManualOccupationRefSourceVerify
	{
		// Token: 0x06019C62 RID: 105570 RVA: 0x003B0996 File Offset: 0x003AEB96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
