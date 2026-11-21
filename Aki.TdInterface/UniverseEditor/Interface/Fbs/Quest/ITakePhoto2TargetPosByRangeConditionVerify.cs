using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045FA RID: 17914
	public static class ITakePhoto2TargetPosByRangeConditionVerify
	{
		// Token: 0x0601A2FF RID: 107263 RVA: 0x003BAD2C File Offset: 0x003B8F2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITakePhoto2TargetPosByRangeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2TargetPosByRangeConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TRangeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081A9 RID: 33193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014321 RID: 82721
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
