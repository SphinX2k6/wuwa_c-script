using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D51 RID: 27985
	public static class IEntityActionContextVerify
	{
		// Token: 0x0603045F RID: 197727 RVA: 0x0068FA19 File Offset: 0x0068DC19
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
