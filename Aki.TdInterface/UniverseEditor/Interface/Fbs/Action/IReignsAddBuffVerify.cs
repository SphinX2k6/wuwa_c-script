using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E21 RID: 28193
	public static class IReignsAddBuffVerify
	{
		// Token: 0x06031D10 RID: 204048 RVA: 0x006BE76E File Offset: 0x006BC96E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
