using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005840 RID: 22592
	public static class IRenderBookPageVerify
	{
		// Token: 0x06026021 RID: 155681 RVA: 0x0053D48C File Offset: 0x0053B68C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRenderBookPageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenderBookPageVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 12, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C06 RID: 31750
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D9 RID: 79577
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
