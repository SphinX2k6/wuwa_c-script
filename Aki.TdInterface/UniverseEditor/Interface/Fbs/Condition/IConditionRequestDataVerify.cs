using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BEE RID: 19438
	public static class IConditionRequestDataVerify
	{
		// Token: 0x0601EC58 RID: 126040 RVA: 0x0044F9A0 File Offset: 0x0044DBA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IConditionRequestDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionRequestDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TConditionDebugDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A5A RID: 31322
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013422 RID: 78882
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
