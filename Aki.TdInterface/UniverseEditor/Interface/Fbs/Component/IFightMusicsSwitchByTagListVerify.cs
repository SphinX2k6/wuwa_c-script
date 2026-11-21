using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AD RID: 22445
	public static class IFightMusicsSwitchByTagListVerify
	{
		// Token: 0x060243C6 RID: 148422 RVA: 0x004FB308 File Offset: 0x004F9508
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFightMusicsSwitchByTagListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFightMusicsSwitchByTagListVerify.<>O.<0>__Verify = new VerifyTableAction(IFightMusicSwitchByTagVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008379 RID: 33657
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145D5 RID: 83413
			public static VerifyTableAction <0>__Verify;
		}
	}
}
