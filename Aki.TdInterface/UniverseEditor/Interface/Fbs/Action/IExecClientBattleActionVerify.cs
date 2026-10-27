using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006707 RID: 26375
	public static class IExecClientBattleActionVerify
	{
		// Token: 0x0602DDFC RID: 187900 RVA: 0x00646018 File Offset: 0x00644218
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExecClientBattleActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecClientBattleActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TExecClientBattleOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D5C RID: 32092
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138DA RID: 80090
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
