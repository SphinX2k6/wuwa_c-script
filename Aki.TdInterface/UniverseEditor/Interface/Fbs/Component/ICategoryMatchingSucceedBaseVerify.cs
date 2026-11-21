using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A1 RID: 21665
	public static class ICategoryMatchingSucceedBaseVerify
	{
		// Token: 0x060221D4 RID: 139732 RVA: 0x004B3EA0 File Offset: 0x004B20A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingSucceedBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingSucceedBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICategoryMatchingSucceedBaseVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICategoryMatchingSucceedBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082FB RID: 33531
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014504 RID: 83204
			public static VerifyTableAction <0>__Verify;
		}
	}
}
