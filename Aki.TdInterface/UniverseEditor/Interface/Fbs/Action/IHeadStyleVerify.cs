using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CC RID: 26828
	public static class IHeadStyleVerify
	{
		// Token: 0x0602ECAF RID: 191663 RVA: 0x00662C06 File Offset: 0x00660E06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
