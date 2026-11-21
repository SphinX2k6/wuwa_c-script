using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D03 RID: 27907
	public static class IEnableSplineMoveModelVerify
	{
		// Token: 0x0603020F RID: 197135 RVA: 0x0068BD2C File Offset: 0x00689F2C
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

		// Token: 0x020085C6 RID: 34246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014976 RID: 84342
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
