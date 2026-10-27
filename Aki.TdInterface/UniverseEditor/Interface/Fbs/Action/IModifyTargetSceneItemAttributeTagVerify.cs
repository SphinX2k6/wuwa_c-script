using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD5 RID: 27349
	public static class IModifyTargetSceneItemAttributeTagVerify
	{
		// Token: 0x0602FEFD RID: 196349 RVA: 0x00684F8C File Offset: 0x0068318C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
