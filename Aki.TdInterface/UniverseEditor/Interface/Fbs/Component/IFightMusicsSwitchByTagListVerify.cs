using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005245 RID: 21061
	public static class IFightMusicsSwitchByTagListVerify
	{
		// Token: 0x06022430 RID: 140336 RVA: 0x004C0844 File Offset: 0x004BEA44
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

		// Token: 0x02007B1E RID: 31518
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013555 RID: 79189
			public static VerifyTableAction <0>__Verify;
		}
	}
}
