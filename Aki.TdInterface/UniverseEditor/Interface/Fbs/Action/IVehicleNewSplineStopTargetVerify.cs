using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D1E RID: 32030
	public static class IVehicleNewSplineStopTargetVerify
	{
		// Token: 0x06039D20 RID: 236832 RVA: 0x007CD1A8 File Offset: 0x007CB3A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleNewSplineStopTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleNewSplineStopTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200875F RID: 34655
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CEB RID: 85227
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
