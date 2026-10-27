using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005191 RID: 20881
	public static class IEntityMatchVerify
	{
		// Token: 0x06021C7C RID: 138364 RVA: 0x004AFCC0 File Offset: 0x004ADEC0
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

		// Token: 0x02007AFD RID: 31485
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013520 RID: 79136
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013521 RID: 79137
			public static VerifyTableAction <1>__Verify;
		}
	}
}
