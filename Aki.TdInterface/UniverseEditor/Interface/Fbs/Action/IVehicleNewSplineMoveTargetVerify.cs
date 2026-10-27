using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007525 RID: 29989
	public static class IVehicleNewSplineMoveTargetVerify
	{
		// Token: 0x060368EB RID: 223467 RVA: 0x007699A4 File Offset: 0x00767BA4
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

		// Token: 0x02007EC4 RID: 32452
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C10 RID: 80912
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
