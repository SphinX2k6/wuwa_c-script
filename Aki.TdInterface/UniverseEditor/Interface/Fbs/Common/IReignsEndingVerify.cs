using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E53 RID: 24147
	public static class IReignsEndingVerify
	{
		// Token: 0x060295A0 RID: 169376 RVA: 0x005AB4B4 File Offset: 0x005A96B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReignsEndingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReignsEndingVerify.<>O.<0>__Verify = new VerifyTableAction(IReignsEndingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CB5 RID: 31925
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E3 RID: 79843
			public static VerifyTableAction <0>__Verify;
		}
	}
}
