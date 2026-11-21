using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAD RID: 27565
	public static class IDartGameplayVerify
	{
		// Token: 0x0602F715 RID: 194325 RVA: 0x00678B88 File Offset: 0x00676D88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDartGameplayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartGameplayVerify.<>O.<0>__Verify = new VerifyUnionAction(TDartInteractTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085B1 RID: 34225
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401495A RID: 84314
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
