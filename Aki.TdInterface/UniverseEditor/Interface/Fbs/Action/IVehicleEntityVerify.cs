using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D0C RID: 32012
	public static class IVehicleEntityVerify
	{
		// Token: 0x06039C5A RID: 236634 RVA: 0x007CB114 File Offset: 0x007C9314
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008759 RID: 34649
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE4 RID: 85220
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
