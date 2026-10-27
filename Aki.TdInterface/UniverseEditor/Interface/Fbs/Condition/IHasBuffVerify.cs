using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C33 RID: 19507
	public static class IHasBuffVerify
	{
		// Token: 0x0601EEA6 RID: 126630 RVA: 0x004536C4 File Offset: 0x004518C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHasBuffVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHasBuffVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A5E RID: 31326
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013426 RID: 78886
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
