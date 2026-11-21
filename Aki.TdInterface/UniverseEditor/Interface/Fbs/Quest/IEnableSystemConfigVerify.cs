using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422E RID: 16942
	public static class IEnableSystemConfigVerify
	{
		// Token: 0x060178F5 RID: 96501 RVA: 0x0035CB1E File Offset: 0x0035AD1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
