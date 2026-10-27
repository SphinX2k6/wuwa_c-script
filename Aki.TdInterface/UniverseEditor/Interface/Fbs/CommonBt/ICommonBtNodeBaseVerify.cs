using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EBF RID: 24255
	public static class ICommonBtNodeBaseVerify
	{
		// Token: 0x06029996 RID: 170390 RVA: 0x005B4CE4 File Offset: 0x005B2EE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
