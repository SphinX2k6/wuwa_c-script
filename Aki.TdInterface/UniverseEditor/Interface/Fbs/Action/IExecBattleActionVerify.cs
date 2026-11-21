using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7B RID: 28027
	public static class IExecBattleActionVerify
	{
		// Token: 0x060305DD RID: 198109 RVA: 0x0069297C File Offset: 0x00690B7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExecBattleActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecBattleActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TExecBattleOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085D1 RID: 34257
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014984 RID: 84356
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
