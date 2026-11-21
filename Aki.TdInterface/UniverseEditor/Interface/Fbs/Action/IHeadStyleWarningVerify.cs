using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F88 RID: 28552
	public static class IHeadStyleWarningVerify
	{
		// Token: 0x060316B5 RID: 202421 RVA: 0x006B34C6 File Offset: 0x006B16C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
