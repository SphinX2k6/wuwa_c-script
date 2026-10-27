using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE1 RID: 28385
	public static class IRogueGotoNextFloorVerify
	{
		// Token: 0x06032286 RID: 205446 RVA: 0x006C7706 File Offset: 0x006C5906
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
