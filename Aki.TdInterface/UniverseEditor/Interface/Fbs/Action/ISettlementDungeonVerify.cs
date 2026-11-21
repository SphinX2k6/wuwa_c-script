using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007868 RID: 30824
	public static class ISettlementDungeonVerify
	{
		// Token: 0x0603635C RID: 222044 RVA: 0x00742EB6 File Offset: 0x007410B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
