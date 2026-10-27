using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B56 RID: 27478
	public static class IMoveSceneItemVerify
	{
		// Token: 0x060303C0 RID: 197568 RVA: 0x0068DD94 File Offset: 0x0068BF94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMoveSceneItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveSceneItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveSceneItemVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DBB RID: 32187
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013959 RID: 80217
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
