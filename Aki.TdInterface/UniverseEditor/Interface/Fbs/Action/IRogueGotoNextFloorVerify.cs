using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007665 RID: 30309
	public static class IRogueGotoNextFloorVerify
	{
		// Token: 0x060352C6 RID: 217798 RVA: 0x0072343A File Offset: 0x0072163A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
