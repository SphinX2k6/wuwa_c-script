using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E8F RID: 20111
	public static class ICheckDollGrabMachineFinishedVerify
	{
		// Token: 0x0601F28A RID: 127626 RVA: 0x00458840 File Offset: 0x00456A40
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

		// Token: 0x02008274 RID: 33396
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014455 RID: 83029
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
