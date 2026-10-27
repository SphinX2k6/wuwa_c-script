using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D57 RID: 15703
	public static class ICheckPlayerBattleAttributeVerify
	{
		// Token: 0x06015B98 RID: 88984 RVA: 0x00322478 File Offset: 0x00320678
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

		// Token: 0x020078BB RID: 30907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013134 RID: 78132
			public static VerifyTableAction <0>__Verify;
		}
	}
}
