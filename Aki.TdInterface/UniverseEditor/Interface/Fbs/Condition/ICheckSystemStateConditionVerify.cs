using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200502A RID: 20522
	public static class ICheckSystemStateConditionVerify
	{
		// Token: 0x060200D6 RID: 131286 RVA: 0x00472798 File Offset: 0x00470998
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckSystemStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckSystemStateConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckSystemStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200829D RID: 33437
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014481 RID: 83073
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
