using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC7 RID: 16071
	public static class IScoreDisplayMaterialParamsVerify
	{
		// Token: 0x06015C17 RID: 89111 RVA: 0x00321768 File Offset: 0x0031F968
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

		// Token: 0x020080C0 RID: 32960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014140 RID: 82240
			public static VerifyTableAction <0>__Verify;
		}
	}
}
