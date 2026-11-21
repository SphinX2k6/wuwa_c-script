using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E40 RID: 15936
	public static class IBvbMaxBoardCardCountVerify
	{
		// Token: 0x0601575A RID: 87898 RVA: 0x00318FFA File Offset: 0x003171FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
