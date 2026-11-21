using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A8 RID: 20648
	public static class IComparePlayerMotionStateVerify
	{
		// Token: 0x06020525 RID: 132389 RVA: 0x00479F70 File Offset: 0x00478170
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

		// Token: 0x020082A5 RID: 33445
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401448B RID: 83083
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
