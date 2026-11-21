using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A8 RID: 21416
	public static class IAirWallSpawnerComponentVerify
	{
		// Token: 0x060216EC RID: 136940 RVA: 0x0049CD1C File Offset: 0x0049AF1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
			{
				short offsetId = 20;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAirWallSpawnerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAirWallSpawnerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 22;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAirWallSpawnerComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAirWallSpawnerComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IAirWallWholeSpawnModeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082CE RID: 33486
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144BC RID: 83132
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144BD RID: 83133
			public static VerifyTableAction <1>__Verify;
		}
	}
}
