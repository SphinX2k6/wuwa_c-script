using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E8B RID: 16011
	public static class IFishFollowStateVerify
	{
		// Token: 0x060159C9 RID: 88521 RVA: 0x0031D3B4 File Offset: 0x0031B5B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFishFollowStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFishFollowStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFishFollowStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFishFollowStateVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080BC RID: 32956
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401413B RID: 82235
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401413C RID: 82236
			public static VerifyTableAction <1>__Verify;
		}
	}
}
