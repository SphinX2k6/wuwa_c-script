using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200496D RID: 18797
	public static class ILevelPlayListVerify
	{
		// Token: 0x0601C083 RID: 114819 RVA: 0x003F6888 File Offset: 0x003F4A88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayListVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelPlayListVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelPlayListVerify.<>O.<1>__Verify = new VerifyTableAction(ISyncBlockGroupVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081FA RID: 33274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B2 RID: 82866
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143B3 RID: 82867
			public static VerifyTableAction <1>__Verify;
		}
	}
}
