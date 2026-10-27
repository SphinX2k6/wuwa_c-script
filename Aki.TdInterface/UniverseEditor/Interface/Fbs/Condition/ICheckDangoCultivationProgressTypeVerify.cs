using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049BD RID: 18877
	public static class ICheckDangoCultivationProgressTypeVerify
	{
		// Token: 0x0601D78F RID: 120719 RVA: 0x00426D36 File Offset: 0x00424F36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
