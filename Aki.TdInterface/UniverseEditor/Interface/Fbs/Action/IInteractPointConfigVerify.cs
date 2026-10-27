using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699E RID: 27038
	public static class IInteractPointConfigVerify
	{
		// Token: 0x0602F3EE RID: 193518 RVA: 0x0066F9F6 File Offset: 0x0066DBF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
