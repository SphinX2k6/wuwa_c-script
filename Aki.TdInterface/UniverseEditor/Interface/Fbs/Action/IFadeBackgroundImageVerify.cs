using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFC RID: 28156
	public static class IFadeBackgroundImageVerify
	{
		// Token: 0x060309B8 RID: 199096 RVA: 0x006995B0 File Offset: 0x006977B0
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

		// Token: 0x020085DB RID: 34267
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401498F RID: 84367
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014990 RID: 84368
			public static VerifyTableAction <1>__Verify;
		}
	}
}
