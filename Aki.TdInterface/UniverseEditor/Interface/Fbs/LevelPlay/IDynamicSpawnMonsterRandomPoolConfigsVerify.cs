using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A8 RID: 17576
	public static class IDynamicSpawnMonsterRandomPoolConfigsVerify
	{
		// Token: 0x0601A3EB RID: 107499 RVA: 0x003BFD81 File Offset: 0x003BDF81
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

		// Token: 0x020079A7 RID: 31143
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013331 RID: 78641
			public static VerifyTableAction <0>__Verify;
		}
	}
}
