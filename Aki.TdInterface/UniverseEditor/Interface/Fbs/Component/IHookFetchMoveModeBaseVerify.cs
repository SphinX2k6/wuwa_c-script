using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593E RID: 22846
	public static class IHookFetchMoveModeBaseVerify
	{
		// Token: 0x060252B1 RID: 152241 RVA: 0x00519B0E File Offset: 0x00517D0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
