using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050FB RID: 20731
	public static class IDynamicSpawnMonsterComponentVerify
	{
		// Token: 0x06021638 RID: 136760 RVA: 0x004A2E40 File Offset: 0x004A1040
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

		// Token: 0x02007AE7 RID: 31463
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134FD RID: 79101
			public static VerifyTableAction <0>__Verify;
		}
	}
}
