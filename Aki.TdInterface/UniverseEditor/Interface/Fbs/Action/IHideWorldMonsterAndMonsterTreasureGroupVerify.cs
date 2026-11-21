using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCA RID: 28618
	public static class IHideWorldMonsterAndMonsterTreasureGroupVerify
	{
		// Token: 0x06031949 RID: 203081 RVA: 0x006B7EF7 File Offset: 0x006B60F7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
