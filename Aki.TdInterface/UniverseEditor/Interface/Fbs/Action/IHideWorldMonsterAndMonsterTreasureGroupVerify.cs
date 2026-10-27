using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006917 RID: 26903
	public static class IHideWorldMonsterAndMonsterTreasureGroupVerify
	{
		// Token: 0x0602EF79 RID: 192377 RVA: 0x00667A0F File Offset: 0x00665C0F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
