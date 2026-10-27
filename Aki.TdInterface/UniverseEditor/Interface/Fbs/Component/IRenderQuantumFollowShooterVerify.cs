using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584B RID: 22603
	public static class IRenderQuantumFollowShooterVerify
	{
		// Token: 0x060260A8 RID: 155816 RVA: 0x0053EAD0 File Offset: 0x0053CCD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRenderQuantumFollowShooterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenderQuantumFollowShooterVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRenderQuantumFollowShooterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRenderQuantumFollowShooterVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRenderQuantumFollowShooterVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IRenderQuantumFollowShooterVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRenderQuantumFollowShooterVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IRenderQuantumFollowShooterVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C09 RID: 31753
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136DD RID: 79581
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040136DE RID: 79582
			public static VerifyTableAction <1>__Verify;
		}
	}
}
