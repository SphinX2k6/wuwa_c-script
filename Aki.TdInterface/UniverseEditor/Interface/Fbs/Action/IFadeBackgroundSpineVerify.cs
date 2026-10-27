using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677F RID: 26495
	public static class IFadeBackgroundSpineVerify
	{
		// Token: 0x0602E190 RID: 188816 RVA: 0x0064C288 File Offset: 0x0064A488
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFadeBackgroundSpineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeBackgroundSpineVerify.<>O.<0>__Verify = new VerifyTableAction(IFadeBackgroundFadeInEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFadeBackgroundSpineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFadeBackgroundSpineVerify.<>O.<1>__Verify = new VerifyTableAction(IFadeBackgroundFadeOutEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D65 RID: 32101
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138E5 RID: 80101
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138E6 RID: 80102
			public static VerifyTableAction <1>__Verify;
		}
	}
}
