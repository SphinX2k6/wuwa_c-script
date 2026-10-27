using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACC RID: 27340
	public static class IModifySceneItemAttributeTagVerify
	{
		// Token: 0x0602FE9F RID: 196255 RVA: 0x00684531 File Offset: 0x00682731
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
