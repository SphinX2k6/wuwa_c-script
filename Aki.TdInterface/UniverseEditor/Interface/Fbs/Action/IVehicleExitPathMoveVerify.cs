using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751C RID: 29980
	public static class IVehicleExitPathMoveVerify
	{
		// Token: 0x0603687D RID: 223357 RVA: 0x0076872C File Offset: 0x0076692C
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

		// Token: 0x02007EC1 RID: 32449
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C0C RID: 80908
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
