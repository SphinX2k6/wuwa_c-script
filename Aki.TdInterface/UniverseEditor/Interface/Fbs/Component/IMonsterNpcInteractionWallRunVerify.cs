using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005595 RID: 21909
	public static class IMonsterNpcInteractionWallRunVerify
	{
		// Token: 0x06024452 RID: 148562 RVA: 0x0050203A File Offset: 0x0050023A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
