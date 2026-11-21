using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006496 RID: 25750
	public static class IReignsEndingConditionVerify
	{
		// Token: 0x0602BC58 RID: 179288 RVA: 0x005F4728 File Offset: 0x005F2928
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReignsEndingConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReignsEndingConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ICompareReignsPropertyVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008527 RID: 34087
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401488A RID: 84106
			public static VerifyTableAction <0>__Verify;
		}
	}
}
