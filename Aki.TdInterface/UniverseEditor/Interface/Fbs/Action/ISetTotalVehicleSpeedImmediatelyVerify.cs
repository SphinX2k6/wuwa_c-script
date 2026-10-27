using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709F RID: 28831
	public static class ISetTotalVehicleSpeedImmediatelyVerify
	{
		// Token: 0x060330D4 RID: 209108 RVA: 0x006E2BD8 File Offset: 0x006E0DD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetTotalVehicleSpeedImmediatelyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetTotalVehicleSpeedImmediatelyVerify.<>O.<0>__Verify = new VerifyUnionAction(TProcessedValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E57 RID: 32343
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A2E RID: 80430
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
