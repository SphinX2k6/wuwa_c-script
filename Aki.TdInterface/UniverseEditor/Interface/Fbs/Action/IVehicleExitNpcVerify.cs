using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D0F RID: 32015
	public static class IVehicleExitNpcVerify
	{
		// Token: 0x06039C76 RID: 236662 RVA: 0x007CB548 File Offset: 0x007C9748
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleExitNpcVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleExitNpcVerify.<>O.<0>__Verify = new VerifyUnionAction(TExitVehicleTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200875A RID: 34650
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE5 RID: 85221
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
