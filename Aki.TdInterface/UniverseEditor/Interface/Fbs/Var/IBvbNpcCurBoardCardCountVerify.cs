using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E49 RID: 15945
	public static class IBvbNpcCurBoardCardCountVerify
	{
		// Token: 0x06015790 RID: 87952 RVA: 0x00319462 File Offset: 0x00317662
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
