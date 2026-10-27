using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200521E RID: 21022
	public static class IFaceToTargetMotorInteractConstraintVerify
	{
		// Token: 0x060222A8 RID: 139944 RVA: 0x004BD7DC File Offset: 0x004BB9DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFaceToTargetMotorInteractConstraintVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFaceToTargetMotorInteractConstraintVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B19 RID: 31513
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401354C RID: 79180
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
