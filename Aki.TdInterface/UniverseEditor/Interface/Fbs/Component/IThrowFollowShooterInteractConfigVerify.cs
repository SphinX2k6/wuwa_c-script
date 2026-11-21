using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006073 RID: 24691
	public static class IThrowFollowShooterInteractConfigVerify
	{
		// Token: 0x06029B9A RID: 170906 RVA: 0x005B26CC File Offset: 0x005B08CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IThrowFollowShooterInteractConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IThrowFollowShooterInteractConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IThrowFollowShooterInteractConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IThrowFollowShooterInteractConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IThrowFollowShooterInteractConfigVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IThrowFollowShooterInteractConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020084C9 RID: 33993
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401480C RID: 83980
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401480D RID: 83981
			public static VerifyTableAction <1>__Verify;
		}
	}
}
