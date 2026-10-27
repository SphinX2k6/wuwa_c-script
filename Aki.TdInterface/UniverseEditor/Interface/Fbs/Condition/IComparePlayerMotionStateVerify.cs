using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BBE RID: 19390
	public static class IComparePlayerMotionStateVerify
	{
		// Token: 0x0601E979 RID: 125305 RVA: 0x0044740C File Offset: 0x0044560C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IComparePlayerMotionStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IComparePlayerMotionStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A53 RID: 31315
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401341B RID: 78875
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
