using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006103 RID: 24835
	public static class IActorTurnToEmptyDataVerify
	{
		// Token: 0x0602A6EE RID: 173806 RVA: 0x005D88F2 File Offset: 0x005D6AF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
