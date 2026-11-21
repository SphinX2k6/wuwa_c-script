using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745B RID: 29787
	public static class IPlayEffectVerify
	{
		// Token: 0x06034262 RID: 213602 RVA: 0x00706CB8 File Offset: 0x00704EB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TPos2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200867C RID: 34428
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A68 RID: 84584
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
