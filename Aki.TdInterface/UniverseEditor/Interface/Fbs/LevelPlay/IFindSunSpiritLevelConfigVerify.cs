using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C9 RID: 17609
	public static class IFindSunSpiritLevelConfigVerify
	{
		// Token: 0x0601A515 RID: 107797 RVA: 0x003C1F60 File Offset: 0x003C0160
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFindSunSpiritLevelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFindSunSpiritLevelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFindSunSpiritGridConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079AA RID: 31146
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013334 RID: 78644
			public static VerifyTableAction <0>__Verify;
		}
	}
}
