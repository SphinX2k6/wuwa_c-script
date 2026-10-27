using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BF RID: 27071
	public static class IItemGetUiConfigBaseVerify
	{
		// Token: 0x0602F4D4 RID: 193748 RVA: 0x006711CE File Offset: 0x0066F3CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
