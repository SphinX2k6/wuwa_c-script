using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751F RID: 29983
	public static class IVehicleExitPlayerVerify
	{
		// Token: 0x0603689D RID: 223389 RVA: 0x00768BEC File Offset: 0x00766DEC
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

		// Token: 0x02007EC2 RID: 32450
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C0D RID: 80909
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
