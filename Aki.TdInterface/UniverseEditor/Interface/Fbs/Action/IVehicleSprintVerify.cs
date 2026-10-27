using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007534 RID: 30004
	public static class IVehicleSprintVerify
	{
		// Token: 0x0603697B RID: 223611 RVA: 0x0076AE1C File Offset: 0x0076901C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleSprintVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleSprintVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EC8 RID: 32456
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C14 RID: 80916
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
