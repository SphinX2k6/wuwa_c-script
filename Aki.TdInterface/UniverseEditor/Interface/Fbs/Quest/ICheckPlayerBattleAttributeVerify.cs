using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416E RID: 16750
	public static class ICheckPlayerBattleAttributeVerify
	{
		// Token: 0x060170D0 RID: 94416 RVA: 0x003496F0 File Offset: 0x003478F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerBattleAttributeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerBattleAttributeVerify.<>O.<0>__Verify = new VerifyTableAction(IHealthAttributeToTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080FF RID: 33023
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014190 RID: 82320
			public static VerifyTableAction <0>__Verify;
		}
	}
}
