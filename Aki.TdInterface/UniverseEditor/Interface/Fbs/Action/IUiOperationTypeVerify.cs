using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A7 RID: 29863
	public static class IUiOperationTypeVerify
	{
		// Token: 0x060364BD RID: 222397 RVA: 0x007614BA File Offset: 0x0075F6BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
