using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200653C RID: 25916
	public static class IDartGameplayVerify
	{
		// Token: 0x0602CF61 RID: 184161 RVA: 0x0062C4DC File Offset: 0x0062A6DC
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

		// Token: 0x02007D3B RID: 32059
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138AE RID: 80046
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
