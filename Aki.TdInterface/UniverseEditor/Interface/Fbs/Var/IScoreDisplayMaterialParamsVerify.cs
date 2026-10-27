using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC5 RID: 15045
	public static class IScoreDisplayMaterialParamsVerify
	{
		// Token: 0x0601476D RID: 83821 RVA: 0x002FB4D8 File Offset: 0x002F96D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IScoreDisplayMaterialParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IScoreDisplayMaterialParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IScoreDisplayParamsVarVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200787D RID: 30845
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E5 RID: 78053
			public static VerifyTableAction <0>__Verify;
		}
	}
}
