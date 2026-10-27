using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A66 RID: 23142
	public static class IThrowFollowShooterInteractConfigVerify
	{
		// Token: 0x06027622 RID: 161314 RVA: 0x0056B6C0 File Offset: 0x005698C0
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

		// Token: 0x02007C5A RID: 31834
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013768 RID: 79720
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013769 RID: 79721
			public static VerifyTableAction <1>__Verify;
		}
	}
}
