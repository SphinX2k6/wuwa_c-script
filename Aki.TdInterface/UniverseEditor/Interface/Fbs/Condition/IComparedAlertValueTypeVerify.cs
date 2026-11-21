using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005075 RID: 20597
	public static class IComparedAlertValueTypeVerify
	{
		// Token: 0x0602035F RID: 131935 RVA: 0x0047710A File Offset: 0x0047530A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
