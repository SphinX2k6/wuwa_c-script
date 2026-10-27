using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200609D RID: 24733
	public static class IActorFaceExpressionVerify
	{
		// Token: 0x0602A37B RID: 172923 RVA: 0x005D2130 File Offset: 0x005D0330
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorFaceExpressionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFaceExpressionVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorFaceExpressionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CCD RID: 31949
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137FE RID: 79870
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
