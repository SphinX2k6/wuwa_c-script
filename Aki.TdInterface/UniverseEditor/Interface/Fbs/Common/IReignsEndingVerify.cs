using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006493 RID: 25747
	public static class IReignsEndingVerify
	{
		// Token: 0x0602BC3C RID: 179260 RVA: 0x005F435C File Offset: 0x005F255C
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

		// Token: 0x02008526 RID: 34086
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014889 RID: 84105
			public static VerifyTableAction <0>__Verify;
		}
	}
}
