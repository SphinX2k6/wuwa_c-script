using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D54 RID: 15700
	public static class ICheckMonsterBattleAttributeVerify
	{
		// Token: 0x06015B82 RID: 88962 RVA: 0x003221DC File Offset: 0x003203DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckMonsterBattleAttributeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckMonsterBattleAttributeVerify.<>O.<0>__Verify = new VerifyTableAction(IHealthAttributeToTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078BA RID: 30906
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013133 RID: 78131
			public static VerifyTableAction <0>__Verify;
		}
	}
}
