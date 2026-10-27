using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A41 RID: 19009
	public static class ICheckGiantTotalProgressInteractActivatedNodeVerify
	{
		// Token: 0x0601DC3F RID: 121919 RVA: 0x0042F79B File Offset: 0x0042D99B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
