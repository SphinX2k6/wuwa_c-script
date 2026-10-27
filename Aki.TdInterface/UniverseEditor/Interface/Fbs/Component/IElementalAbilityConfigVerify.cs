using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005125 RID: 20773
	public static class IElementalAbilityConfigVerify
	{
		// Token: 0x060217BE RID: 137150 RVA: 0x004A5FC8 File Offset: 0x004A41C8
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

		// Token: 0x02007AEC RID: 31468
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013506 RID: 79110
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013507 RID: 79111
			public static VerifyTableAction <1>__Verify;
		}
	}
}
