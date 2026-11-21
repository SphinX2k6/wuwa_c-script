using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744D RID: 29773
	public static class IPlayCommonEffectVerify
	{
		// Token: 0x060341C4 RID: 213444 RVA: 0x007057BC File Offset: 0x007039BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayCommonEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayCommonEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TEffectPos2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008679 RID: 34425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A65 RID: 84581
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
