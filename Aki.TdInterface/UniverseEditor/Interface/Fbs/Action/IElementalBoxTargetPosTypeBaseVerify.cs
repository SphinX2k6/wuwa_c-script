using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA3 RID: 27811
	public static class IElementalBoxTargetPosTypeBaseVerify
	{
		// Token: 0x0602FEC1 RID: 196289 RVA: 0x0068606E File Offset: 0x0068426E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
