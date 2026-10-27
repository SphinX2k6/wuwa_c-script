using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007120 RID: 28960
	public static class ISkiConfigVerify
	{
		// Token: 0x0603358F RID: 210319 RVA: 0x006EBDA0 File Offset: 0x006E9FA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISkiConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkiConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TSkiConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E61 RID: 32353
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A3E RID: 80446
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
