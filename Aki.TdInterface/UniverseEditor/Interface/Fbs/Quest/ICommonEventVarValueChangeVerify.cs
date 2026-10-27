using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D99 RID: 15769
	public static class ICommonEventVarValueChangeVerify
	{
		// Token: 0x06015E78 RID: 89720 RVA: 0x00329A88 File Offset: 0x00327C88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonEventVarValueChangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonEventVarValueChangeVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078C2 RID: 30914
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013146 RID: 78150
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
