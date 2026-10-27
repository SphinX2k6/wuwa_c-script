using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A25 RID: 27173
	public static class ILimitPlayerOperationVerify
	{
		// Token: 0x0602F8DB RID: 194779 RVA: 0x006794C0 File Offset: 0x006776C0
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

		// Token: 0x02007D9A RID: 32154
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401392E RID: 80174
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
