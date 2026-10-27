using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB0 RID: 19120
	public static class ICheckJigsawInfoConditionVerify
	{
		// Token: 0x0601E02D RID: 122925 RVA: 0x0043669C File Offset: 0x0043489C
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

		// Token: 0x02007A3C RID: 31292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013400 RID: 78848
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
