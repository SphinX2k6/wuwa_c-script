using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007180 RID: 29056
	public static class ISplineMoveConfigVerify
	{
		// Token: 0x06033845 RID: 211013 RVA: 0x006F08DC File Offset: 0x006EEADC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISplineMoveConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISplineMoveConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E6B RID: 32363
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A4A RID: 80458
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
