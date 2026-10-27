using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063DB RID: 25563
	public static class IClientModifyTargetTagVerify
	{
		// Token: 0x0602C38A RID: 181130 RVA: 0x00612004 File Offset: 0x00610204
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientModifyTargetTagVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientModifyTargetTagVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientModifyTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D20 RID: 32032
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401388B RID: 80011
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
