using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1E RID: 27934
	public static class IEndFlowTemplateVerify
	{
		// Token: 0x060302D3 RID: 197331 RVA: 0x0068CF7A File Offset: 0x0068B17A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
