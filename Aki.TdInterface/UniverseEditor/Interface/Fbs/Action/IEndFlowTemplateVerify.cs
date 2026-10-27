using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A4 RID: 26276
	public static class IEndFlowTemplateVerify
	{
		// Token: 0x0602DAB6 RID: 187062 RVA: 0x0063FCC6 File Offset: 0x0063DEC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
