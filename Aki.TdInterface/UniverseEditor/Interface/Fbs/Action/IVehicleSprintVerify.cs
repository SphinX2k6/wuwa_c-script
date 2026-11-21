using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D2A RID: 32042
	public static class IVehicleSprintVerify
	{
		// Token: 0x06039D91 RID: 236945 RVA: 0x007CE0C4 File Offset: 0x007CC2C4
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

		// Token: 0x02008762 RID: 34658
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CEE RID: 85230
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
