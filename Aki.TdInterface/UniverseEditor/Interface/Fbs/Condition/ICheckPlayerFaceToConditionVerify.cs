using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE9 RID: 19177
	public static class ICheckPlayerFaceToConditionVerify
	{
		// Token: 0x0601E227 RID: 123431 RVA: 0x0043A13C File Offset: 0x0043833C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckPlayerFaceToConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerFaceToConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A41 RID: 31297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013405 RID: 78853
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
