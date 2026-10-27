using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A1 RID: 16801
	public static class ITakePhoto2TargetPosByRangeConditionVerify
	{
		// Token: 0x06018BA9 RID: 101289 RVA: 0x0038F8D8 File Offset: 0x0038DAD8
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

		// Token: 0x02007960 RID: 31072
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132BB RID: 78523
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
