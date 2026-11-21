using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B0 RID: 16816
	public static class ICommonEventVarValueChangeVerify
	{
		// Token: 0x060173B0 RID: 95152 RVA: 0x00350DB4 File Offset: 0x0034EFB4
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

		// Token: 0x02008106 RID: 33030
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141A2 RID: 82338
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
