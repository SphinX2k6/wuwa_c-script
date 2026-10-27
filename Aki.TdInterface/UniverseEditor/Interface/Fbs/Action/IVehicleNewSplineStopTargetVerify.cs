using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007528 RID: 29992
	public static class IVehicleNewSplineStopTargetVerify
	{
		// Token: 0x0603690A RID: 223498 RVA: 0x00769F00 File Offset: 0x00768100
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

		// Token: 0x02007EC5 RID: 32453
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C11 RID: 80913
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
