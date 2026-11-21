using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044FB RID: 17659
	public static class IRogueTowerTrialSystemVarVerify
	{
		// Token: 0x060198EA RID: 104682 RVA: 0x003A4D9C File Offset: 0x003A2F9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRogueTowerTrialSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRogueTowerTrialSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008193 RID: 33171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142D0 RID: 82640
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
