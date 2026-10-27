using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E56 RID: 24150
	public static class IReignsEndingConditionVerify
	{
		// Token: 0x060295BC RID: 169404 RVA: 0x005AB880 File Offset: 0x005A9A80
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

		// Token: 0x02007CB6 RID: 31926
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E4 RID: 79844
			public static VerifyTableAction <0>__Verify;
		}
	}
}
