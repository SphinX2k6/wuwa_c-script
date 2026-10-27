using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677C RID: 26492
	public static class IFadeBackgroundImageVerify
	{
		// Token: 0x0602E172 RID: 188786 RVA: 0x0064BE6C File Offset: 0x0064A06C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFadeBackgroundImageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeBackgroundImageVerify.<>O.<0>__Verify = new VerifyTableAction(IFadeBackgroundFadeInEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFadeBackgroundImageVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFadeBackgroundImageVerify.<>O.<1>__Verify = new VerifyTableAction(IFadeBackgroundFadeOutEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D64 RID: 32100
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138E3 RID: 80099
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138E4 RID: 80100
			public static VerifyTableAction <1>__Verify;
		}
	}
}
