using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005804 RID: 22532
	public static class IFollowShooterComponentVerify
	{
		// Token: 0x06024739 RID: 149305 RVA: 0x00502628 File Offset: 0x00500828
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowShooterComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowShooterComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFollowShooterJellyFishConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFollowShooterComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFollowShooterComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityCategoryVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008388 RID: 33672
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145EA RID: 83434
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145EB RID: 83435
			public static VerifyTableAction <1>__Verify;
		}
	}
}
