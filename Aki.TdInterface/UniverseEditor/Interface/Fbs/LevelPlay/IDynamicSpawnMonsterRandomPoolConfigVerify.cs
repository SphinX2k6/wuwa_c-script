using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200490D RID: 18701
	public static class IDynamicSpawnMonsterRandomPoolConfigVerify
	{
		// Token: 0x0601BBA4 RID: 113572 RVA: 0x003EBC48 File Offset: 0x003E9E48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSpawnMonsterRandomPoolConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSpawnMonsterRandomPoolConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicSpawnMonsterGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081EF RID: 33263
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014397 RID: 82839
			public static VerifyTableAction <0>__Verify;
		}
	}
}
