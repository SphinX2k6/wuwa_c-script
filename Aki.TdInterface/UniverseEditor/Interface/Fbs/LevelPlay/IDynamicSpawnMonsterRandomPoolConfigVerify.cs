using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A5 RID: 17573
	public static class IDynamicSpawnMonsterRandomPoolConfigVerify
	{
		// Token: 0x0601A3D3 RID: 107475 RVA: 0x003BFA3C File Offset: 0x003BDC3C
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

		// Token: 0x020079A6 RID: 31142
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013330 RID: 78640
			public static VerifyTableAction <0>__Verify;
		}
	}
}
