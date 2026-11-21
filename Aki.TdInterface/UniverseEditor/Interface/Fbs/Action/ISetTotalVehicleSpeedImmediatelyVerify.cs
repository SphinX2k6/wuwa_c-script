using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200786B RID: 30827
	public static class ISetTotalVehicleSpeedImmediatelyVerify
	{
		// Token: 0x06036376 RID: 222070 RVA: 0x007431E4 File Offset: 0x007413E4
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

		// Token: 0x020086ED RID: 34541
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B02 RID: 84738
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
