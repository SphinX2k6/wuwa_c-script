using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078EF RID: 30959
	public static class ISkiConfigTypeVerify
	{
		// Token: 0x0603684E RID: 223310 RVA: 0x0074C838 File Offset: 0x0074AA38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISkiConfigTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkiConfigTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F8 RID: 34552
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B13 RID: 84755
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
