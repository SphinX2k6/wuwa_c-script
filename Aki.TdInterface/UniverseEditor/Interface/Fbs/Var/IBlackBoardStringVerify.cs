using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A1D RID: 14877
	public static class IBlackBoardStringVerify
	{
		// Token: 0x060141DC RID: 82396 RVA: 0x002F1734 File Offset: 0x002EF934
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
