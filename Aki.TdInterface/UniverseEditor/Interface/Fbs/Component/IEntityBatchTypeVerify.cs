using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C9 RID: 22217
	public static class IEntityBatchTypeVerify
	{
		// Token: 0x060239A1 RID: 145825 RVA: 0x004E540A File Offset: 0x004E360A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
