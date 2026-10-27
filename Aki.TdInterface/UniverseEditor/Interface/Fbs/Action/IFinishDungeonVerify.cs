using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A9 RID: 26537
	public static class IFinishDungeonVerify
	{
		// Token: 0x0602E2E3 RID: 189155 RVA: 0x0064E95A File Offset: 0x0064CB5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
