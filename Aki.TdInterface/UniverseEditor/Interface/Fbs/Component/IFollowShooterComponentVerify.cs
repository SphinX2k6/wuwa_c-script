using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200529C RID: 21148
	public static class IFollowShooterComponentVerify
	{
		// Token: 0x0602279F RID: 141215 RVA: 0x004C7AB8 File Offset: 0x004C5CB8
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

		// Token: 0x02007B2D RID: 31533
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401356A RID: 79210
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401356B RID: 79211
			public static VerifyTableAction <1>__Verify;
		}
	}
}
