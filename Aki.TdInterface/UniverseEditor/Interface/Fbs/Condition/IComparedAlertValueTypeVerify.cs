using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B8E RID: 19342
	public static class IComparedAlertValueTypeVerify
	{
		// Token: 0x0601E7D1 RID: 124881 RVA: 0x004448BE File Offset: 0x00442ABE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
