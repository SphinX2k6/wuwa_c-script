using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FBE RID: 20414
	public static class ICheckPlayerFaceToConditionVerify
	{
		// Token: 0x0601FD3C RID: 130364 RVA: 0x0046BDE8 File Offset: 0x00469FE8
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

		// Token: 0x02008292 RID: 33426
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014474 RID: 83060
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
