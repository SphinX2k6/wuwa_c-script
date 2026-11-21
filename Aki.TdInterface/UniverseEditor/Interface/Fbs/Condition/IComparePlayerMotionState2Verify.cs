using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050AB RID: 20651
	public static class IComparePlayerMotionState2Verify
	{
		// Token: 0x06020547 RID: 132423 RVA: 0x0047A408 File Offset: 0x00478608
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IComparePlayerMotionState2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IComparePlayerMotionState2Verify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082A6 RID: 33446
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401448C RID: 83084
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
