using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006788 RID: 26504
	public static class IFadeBackgroundUiPrefabVerify
	{
		// Token: 0x0602E1C8 RID: 188872 RVA: 0x0064C850 File Offset: 0x0064AA50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFadeBackgroundUiPrefabVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeBackgroundUiPrefabVerify.<>O.<0>__Verify = new VerifyTableAction(IFadeBackgroundUiPrefabBlackScreenWhiteTextVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D66 RID: 32102
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138E7 RID: 80103
			public static VerifyTableAction <0>__Verify;
		}
	}
}
