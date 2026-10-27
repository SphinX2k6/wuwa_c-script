using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004852 RID: 18514
	public static class IDeployConfigVerify
	{
		// Token: 0x0601CA87 RID: 117383 RVA: 0x0040D218 File Offset: 0x0040B418
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDeployConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDeployConfigVerify.<>O.<0>__Verify = new VerifyTableAction(Record_Int_IEntityDeployConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDeployConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDeployConfigVerify.<>O.<1>__Verify = new VerifyTableAction(Record_Int_IActorDeployConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDeployConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDeployConfigVerify.<>O.<2>__Verify = new VerifyTableAction(Record_Int_IntVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IDeployConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IDeployConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IComponentFieldModificationVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A0D RID: 31245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133BF RID: 78783
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133C0 RID: 78784
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040133C1 RID: 78785
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040133C2 RID: 78786
			public static VerifyTableAction <3>__Verify;
		}
	}
}
