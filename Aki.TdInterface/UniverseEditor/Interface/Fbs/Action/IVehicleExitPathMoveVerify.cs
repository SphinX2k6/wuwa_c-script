using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D12 RID: 32018
	public static class IVehicleExitPathMoveVerify
	{
		// Token: 0x06039C93 RID: 236691 RVA: 0x007CB9D4 File Offset: 0x007C9BD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleExitPathMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleExitPathMoveVerify.<>O.<0>__Verify = new VerifyUnionAction(TCloseSplineMovePatternVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200875B RID: 34651
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE6 RID: 85222
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
