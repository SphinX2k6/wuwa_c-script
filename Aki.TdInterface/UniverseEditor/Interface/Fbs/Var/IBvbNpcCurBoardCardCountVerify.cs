using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A6E RID: 14958
	public static class IBvbNpcCurBoardCardCountVerify
	{
		// Token: 0x06014474 RID: 83060 RVA: 0x002F6276 File Offset: 0x002F4476
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
