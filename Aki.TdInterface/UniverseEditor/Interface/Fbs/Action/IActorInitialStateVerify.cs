using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D0 RID: 24784
	public static class IActorInitialStateVerify
	{
		// Token: 0x0602A530 RID: 173360 RVA: 0x005D5588 File Offset: 0x005D3788
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorInitialStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorInitialStateVerify.<>O.<0>__Verify = new VerifyTableAction(IActorInitialMontageVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IActorInitialStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActorInitialStateVerify.<>O.<1>__Verify = new VerifyUnionAction(IActorLookAtData_UnionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IActorInitialStateVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IActorInitialStateVerify.<>O.<2>__Verify = new VerifyTableAction(IActorInitialEffectVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007CD3 RID: 31955
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013804 RID: 79876
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013805 RID: 79877
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013806 RID: 79878
			public static VerifyTableAction <2>__Verify;
		}
	}
}
