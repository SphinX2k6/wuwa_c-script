using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A57 RID: 19031
	public static class TCsvFindSunSpiritLevelDataVerify
	{
		// Token: 0x0601C9B3 RID: 117171 RVA: 0x00409768 File Offset: 0x00407968
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvFindSunSpiritLevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvFindSunSpiritLevelDataVerify.<>O.<0>__Verify = new VerifyTableAction(IFindSunSpiritLevelConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008213 RID: 33299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143CD RID: 82893
			public static VerifyTableAction <0>__Verify;
		}
	}
}
