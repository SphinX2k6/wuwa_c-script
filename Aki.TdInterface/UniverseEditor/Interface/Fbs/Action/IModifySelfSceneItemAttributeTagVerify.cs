using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD2 RID: 27346
	public static class IModifySelfSceneItemAttributeTagVerify
	{
		// Token: 0x0602FECF RID: 196303 RVA: 0x00684A31 File Offset: 0x00682C31
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
