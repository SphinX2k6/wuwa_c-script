using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007000 RID: 28672
	public static class ISetHeadIconVisibleVerify
	{
		// Token: 0x06032B7A RID: 207738 RVA: 0x006D7DE4 File Offset: 0x006D5FE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetHeadIconVisibleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetHeadIconVisibleVerify.<>O.<0>__Verify = new VerifyUnionAction(THeadStyleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E3C RID: 32316
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A06 RID: 80390
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
