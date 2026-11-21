using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D1 RID: 27089
	public static class ICheckFlowLookAtConfigVerify
	{
		// Token: 0x0602E7A0 RID: 190368 RVA: 0x00657694 File Offset: 0x00655894
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

		// Token: 0x0200858B RID: 34187
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014926 RID: 84262
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014927 RID: 84263
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04014928 RID: 84264
			public static VerifyTableAction <2>__Verify;
		}
	}
}
