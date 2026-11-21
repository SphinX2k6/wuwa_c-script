using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F52 RID: 28498
	public static class IGuestOperateUiAnimationVerify
	{
		// Token: 0x06031531 RID: 202033 RVA: 0x006AE4A0 File Offset: 0x006AC6A0
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

		// Token: 0x020085FD RID: 34301
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149BA RID: 84410
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
