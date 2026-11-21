using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE6 RID: 24550
	public static class IStreamingSourceConfigBaseVerify
	{
		// Token: 0x060295CF RID: 169423 RVA: 0x005A587A File Offset: 0x005A3A7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
