using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006360 RID: 25440
	public static class ICheckFlowLookAtConfigVerify
	{
		// Token: 0x0602C036 RID: 180278 RVA: 0x0060C540 File Offset: 0x0060A740
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckFlowLookAtConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckFlowLookAtConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICheckFlowLookAtConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckFlowLookAtConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TCheckFlowLookAtTargetVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICheckFlowLookAtConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICheckFlowLookAtConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IEntityLookAtPerformVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D17 RID: 32023
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401387C RID: 79996
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401387D RID: 79997
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401387E RID: 79998
			public static VerifyTableAction <2>__Verify;
		}
	}
}
