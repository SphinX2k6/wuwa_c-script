using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FB RID: 26363
	public static class IExecBattleActionVerify
	{
		// Token: 0x0602DD9E RID: 187806 RVA: 0x00645358 File Offset: 0x00643558
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

		// Token: 0x02007D5A RID: 32090
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D8 RID: 80088
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
