using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F72 RID: 20338
	public static class ICategoryMatchingSucceedBaseVerify
	{
		// Token: 0x06020482 RID: 132226 RVA: 0x0047DEB0 File Offset: 0x0047C0B0
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

		// Token: 0x02007AA5 RID: 31397
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401348E RID: 78990
			public static VerifyTableAction <0>__Verify;
		}
	}
}
