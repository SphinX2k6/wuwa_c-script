using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007087 RID: 28807
	public static class ISetTargetElementalAbilityVerify
	{
		// Token: 0x0603302A RID: 208938 RVA: 0x006E17EC File Offset: 0x006DF9EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetTargetElementalAbilityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetTargetElementalAbilityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E53 RID: 32339
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A2A RID: 80426
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
