using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5F RID: 27487
	public static class IMoveToEntityVerify
	{
		// Token: 0x06030402 RID: 197634 RVA: 0x0068E500 File Offset: 0x0068C700
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMoveToEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveToEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveToPointTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DBC RID: 32188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401395A RID: 80218
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
