using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005786 RID: 22406
	public static class IFaceToTargetMotorInteractConstraintVerify
	{
		// Token: 0x0602423E RID: 148030 RVA: 0x004F82A0 File Offset: 0x004F64A0
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

		// Token: 0x02008374 RID: 33652
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145CC RID: 83404
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
