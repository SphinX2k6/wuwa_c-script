using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CBA RID: 19642
	public static class IDeployConfigVerify
	{
		// Token: 0x0601E284 RID: 123524 RVA: 0x00439B68 File Offset: 0x00437D68
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

		// Token: 0x02008256 RID: 33366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014426 RID: 82982
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014427 RID: 82983
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014428 RID: 82984
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014429 RID: 82985
			public static VerifyTableAction <3>__Verify;
		}
	}
}
