using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBE RID: 28606
	public static class IHideTargetRangeVerify
	{
		// Token: 0x060318A5 RID: 202917 RVA: 0x006B6BA0 File Offset: 0x006B4DA0
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

		// Token: 0x02008603 RID: 34307
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C0 RID: 84416
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
