using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A44 RID: 14916
	public static class IBvbCardFilterGroupVerify
	{
		// Token: 0x0601431F RID: 82719 RVA: 0x002F3C17 File Offset: 0x002F1E17
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
