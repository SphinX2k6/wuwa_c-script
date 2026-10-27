using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B43 RID: 19267
	public static class ICheckSystemStateConditionVerify
	{
		// Token: 0x0601E54A RID: 124234 RVA: 0x0043FF94 File Offset: 0x0043E194
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckSystemStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckSystemStateConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckSystemStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A4B RID: 31307
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013411 RID: 78865
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
