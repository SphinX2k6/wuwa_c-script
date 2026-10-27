using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC9 RID: 20425
	public static class ICombinedVisibleGroupComponentVerify
	{
		// Token: 0x06020864 RID: 133220 RVA: 0x00485F60 File Offset: 0x00484160
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
