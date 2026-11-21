using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006771 RID: 26481
	public static class IActorTurnToTalkerDataVerify
	{
		// Token: 0x0602CE1F RID: 183839 RVA: 0x00623016 File Offset: 0x00621216
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
