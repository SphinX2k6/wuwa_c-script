using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049CF RID: 18895
	public static class ICheckDollGrabMachineFinishedVerify
	{
		// Token: 0x0601D817 RID: 120855 RVA: 0x00427BD4 File Offset: 0x00425DD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckDollGrabMachineFinishedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckDollGrabMachineFinishedVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A25 RID: 31269
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E8 RID: 78824
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
