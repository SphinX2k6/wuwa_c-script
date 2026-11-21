using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F6 RID: 22262
	public static class IEntityMatchVerify
	{
		// Token: 0x06023BD4 RID: 146388 RVA: 0x004E9CE0 File Offset: 0x004E7EE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityMatchVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityMatchVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCategoryVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityMatchVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityMatchVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008357 RID: 33623
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401459E RID: 83358
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401459F RID: 83359
			public static VerifyTableAction <1>__Verify;
		}
	}
}
