using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E7A RID: 24186
	public static class TCsvReignsDataVerify
	{
		// Token: 0x060296F3 RID: 169715 RVA: 0x005ADB18 File Offset: 0x005ABD18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvReignsDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvReignsDataVerify.<>O.<0>__Verify = new VerifyTableAction(IReignsPropertyConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = TCsvReignsDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (TCsvReignsDataVerify.<>O.<1>__Verify = new VerifyTableAction(IReignsEndingVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CB9 RID: 31929
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E7 RID: 79847
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137E8 RID: 79848
			public static VerifyTableAction <1>__Verify;
		}
	}
}
