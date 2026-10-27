using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A65 RID: 14949
	public static class IBvbMaxBoardCardCountVerify
	{
		// Token: 0x0601443E RID: 83006 RVA: 0x002F5E0E File Offset: 0x002F400E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
