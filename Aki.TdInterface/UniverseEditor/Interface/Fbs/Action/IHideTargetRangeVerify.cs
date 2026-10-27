using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690B RID: 26891
	public static class IHideTargetRangeVerify
	{
		// Token: 0x0602EED5 RID: 192213 RVA: 0x006666B8 File Offset: 0x006648B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHideTargetRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHideTargetRangeVerify.<>O.<0>__Verify = new VerifyUnionAction(THideRangeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D88 RID: 32136
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401390F RID: 80143
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
