using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004505 RID: 17669
	public static class ILevelPlayListVerify
	{
		// Token: 0x0601A8AE RID: 108718 RVA: 0x003CA5EC File Offset: 0x003C87EC
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

		// Token: 0x020079B1 RID: 31153
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401334B RID: 78667
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401334C RID: 78668
			public static VerifyTableAction <1>__Verify;
		}
	}
}
