using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006722 RID: 26402
	public static class IExitMonsterMoveWithSplineVerify
	{
		// Token: 0x0602DEDE RID: 188126 RVA: 0x0064773B File Offset: 0x0064593B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
