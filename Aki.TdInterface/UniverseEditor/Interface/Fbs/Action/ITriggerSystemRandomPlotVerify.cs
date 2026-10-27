using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748F RID: 29839
	public static class ITriggerSystemRandomPlotVerify
	{
		// Token: 0x060363A3 RID: 222115 RVA: 0x0075F356 File Offset: 0x0075D556
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
