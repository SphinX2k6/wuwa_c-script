using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F9 RID: 18169
	public static class IHideRangeInfoVerify
	{
		// Token: 0x0601BD2E RID: 113966 RVA: 0x003F1864 File Offset: 0x003EFA64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
