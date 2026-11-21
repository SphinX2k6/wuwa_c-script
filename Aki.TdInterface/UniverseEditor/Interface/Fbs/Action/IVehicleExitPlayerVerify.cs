using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D15 RID: 32021
	public static class IVehicleExitPlayerVerify
	{
		// Token: 0x06039CB3 RID: 236723 RVA: 0x007CBE94 File Offset: 0x007CA094
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleExitPlayerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleExitPlayerVerify.<>O.<0>__Verify = new VerifyUnionAction(TExitVehicleTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200875C RID: 34652
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE7 RID: 85223
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
