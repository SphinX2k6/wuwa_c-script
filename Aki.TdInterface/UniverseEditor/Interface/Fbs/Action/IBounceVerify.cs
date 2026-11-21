using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688E RID: 26766
	public static class IBounceVerify
	{
		// Token: 0x0602DC22 RID: 187426 RVA: 0x006415E0 File Offset: 0x0063F7E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBounceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBounceVerify.<>O.<0>__Verify = new VerifyUnionAction(TCommonTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008569 RID: 34153
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148FD RID: 84221
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
