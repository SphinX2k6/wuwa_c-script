using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB9 RID: 28601
	public static class ISetBattleStateVerify
	{
		// Token: 0x060328CD RID: 207053 RVA: 0x006D25C0 File Offset: 0x006D07C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetBattleStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetBattleStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TStateOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E32 RID: 32306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F0 RID: 80368
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
