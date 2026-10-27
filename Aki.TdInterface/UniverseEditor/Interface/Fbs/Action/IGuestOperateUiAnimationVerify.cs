using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B1 RID: 26801
	public static class IGuestOperateUiAnimationVerify
	{
		// Token: 0x0602EBF7 RID: 191479 RVA: 0x0065F420 File Offset: 0x0065D620
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGuestOperateUiAnimationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGuestOperateUiAnimationVerify.<>O.<0>__Verify = new VerifyUnionAction(TGuestOperateUiAnimationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D84 RID: 32132
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401390B RID: 80139
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
