using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568A RID: 22154
	public static class IElementalAbilityConfigVerify
	{
		// Token: 0x06023712 RID: 145170 RVA: 0x004DFF54 File Offset: 0x004DE154
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IElementalAbilityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalAbilityConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short offsetId = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IElementalAbilityConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IElementalAbilityConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IStateElementalEnableConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008346 RID: 33606
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014584 RID: 83332
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014585 RID: 83333
			public static VerifyTableAction <1>__Verify;
		}
	}
}
