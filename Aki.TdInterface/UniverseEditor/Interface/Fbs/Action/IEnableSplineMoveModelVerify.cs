using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006689 RID: 26249
	public static class IEnableSplineMoveModelVerify
	{
		// Token: 0x0602D9F2 RID: 186866 RVA: 0x0063EA78 File Offset: 0x0063CC78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEnableSplineMoveModelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnableSplineMoveModelVerify.<>O.<0>__Verify = new VerifyUnionAction(TSplineMoveModelVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D4F RID: 32079
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138CA RID: 80074
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
