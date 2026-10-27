using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7E RID: 28286
	public static class IResetEntityVerify
	{
		// Token: 0x06031FE8 RID: 204776 RVA: 0x006C34EC File Offset: 0x006C16EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IResetEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TResetEntityConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E14 RID: 32276
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139CF RID: 80335
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
