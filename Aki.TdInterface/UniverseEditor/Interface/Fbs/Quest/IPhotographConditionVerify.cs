using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C3 RID: 17347
	public static class IPhotographConditionVerify
	{
		// Token: 0x060189FE RID: 100862 RVA: 0x003833DC File Offset: 0x003815DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPhotographConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TPhotographTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200815C RID: 33116
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014262 RID: 82530
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
