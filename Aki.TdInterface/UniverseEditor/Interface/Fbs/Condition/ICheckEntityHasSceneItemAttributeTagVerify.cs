using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A08 RID: 18952
	public static class ICheckEntityHasSceneItemAttributeTagVerify
	{
		// Token: 0x0601DA41 RID: 121409 RVA: 0x0042BE10 File Offset: 0x0042A010
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
