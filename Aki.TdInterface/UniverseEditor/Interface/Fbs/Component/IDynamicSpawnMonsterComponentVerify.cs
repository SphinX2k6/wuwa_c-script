using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005660 RID: 22112
	public static class IDynamicSpawnMonsterComponentVerify
	{
		// Token: 0x0602358C RID: 144780 RVA: 0x004DCDCC File Offset: 0x004DAFCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSpawnMonsterComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSpawnMonsterComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionSpawnMonsterVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008341 RID: 33601
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401457B RID: 83323
			public static VerifyTableAction <0>__Verify;
		}
	}
}
