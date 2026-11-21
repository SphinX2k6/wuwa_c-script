using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D5 RID: 28885
	public static class ILimitPlayerOperationVerify
	{
		// Token: 0x0603229B RID: 205467 RVA: 0x006C9818 File Offset: 0x006C7A18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILimitPlayerOperationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILimitPlayerOperationVerify.<>O.<0>__Verify = new VerifyUnionAction(TLimitPlayOperationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008614 RID: 34324
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149DE RID: 84446
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
