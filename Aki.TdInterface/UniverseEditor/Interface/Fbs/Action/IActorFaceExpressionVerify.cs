using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FF RID: 26367
	public static class IActorFaceExpressionVerify
	{
		// Token: 0x0602CA5C RID: 182876 RVA: 0x0061C0D8 File Offset: 0x0061A2D8
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

		// Token: 0x0200853E RID: 34110
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A4 RID: 84132
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
