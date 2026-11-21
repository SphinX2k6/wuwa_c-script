using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F7F RID: 20351
	public static class ICheckJigsawInfoConditionVerify
	{
		// Token: 0x0601FB16 RID: 129814 RVA: 0x00467EBC File Offset: 0x004660BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckJigsawInfoConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckJigsawInfoConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckJigsawInfoVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200828C RID: 33420
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401446E RID: 83054
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
