using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D1B RID: 32027
	public static class IVehicleNewSplineMoveTargetVerify
	{
		// Token: 0x06039D01 RID: 236801 RVA: 0x007CCC4C File Offset: 0x007CAE4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleNewSplineMoveTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleNewSplineMoveTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200875E RID: 34654
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CEA RID: 85226
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
