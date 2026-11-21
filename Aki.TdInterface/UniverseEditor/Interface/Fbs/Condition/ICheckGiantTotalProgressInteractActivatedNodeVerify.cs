using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F04 RID: 20228
	public static class ICheckGiantTotalProgressInteractActivatedNodeVerify
	{
		// Token: 0x0601F6C8 RID: 128712 RVA: 0x00460693 File Offset: 0x0045E893
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
