using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004910 RID: 18704
	public static class IDynamicSpawnMonsterRandomPoolConfigsVerify
	{
		// Token: 0x0601BBBC RID: 113596 RVA: 0x003EBF8D File Offset: 0x003EA18D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSpawnMonsterRandomPoolConfigsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSpawnMonsterRandomPoolConfigsVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicSpawnMonsterRandomPoolConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081F0 RID: 33264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014398 RID: 82840
			public static VerifyTableAction <0>__Verify;
		}
	}
}
