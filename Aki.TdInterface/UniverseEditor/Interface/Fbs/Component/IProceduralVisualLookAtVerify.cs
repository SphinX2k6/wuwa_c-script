using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA2 RID: 23970
	public static class IProceduralVisualLookAtVerify
	{
		// Token: 0x06027EEA RID: 163562 RVA: 0x005761C4 File Offset: 0x005743C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProceduralVisualLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProceduralVisualLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IProceduralVisualLookAtVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IProceduralVisualLookAtVerify.<>O.<1>__Verify = new VerifyUnionAction(TLookAtTargetVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008456 RID: 33878
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401474D RID: 83789
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401474E RID: 83790
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
