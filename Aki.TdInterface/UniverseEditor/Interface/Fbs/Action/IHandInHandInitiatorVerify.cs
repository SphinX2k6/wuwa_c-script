using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C0 RID: 26816
	public static class IHandInHandInitiatorVerify
	{
		// Token: 0x0602EC6B RID: 191595 RVA: 0x00662618 File Offset: 0x00660818
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHandInHandInitiatorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandInHandInitiatorVerify.<>O.<0>__Verify = new VerifyUnionAction(THandInHandInitiatorVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D85 RID: 32133
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401390C RID: 80140
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
