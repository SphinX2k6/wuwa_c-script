using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E1 RID: 18913
	public static class ICheckElementalBoxStateVerify
	{
		// Token: 0x0601D8B9 RID: 121017 RVA: 0x00428D60 File Offset: 0x00426F60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckElementalBoxStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckElementalBoxStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TElementalBoxStateTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A26 RID: 31270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E9 RID: 78825
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
