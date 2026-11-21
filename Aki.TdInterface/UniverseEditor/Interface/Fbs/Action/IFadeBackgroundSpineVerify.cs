using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFF RID: 28159
	public static class IFadeBackgroundSpineVerify
	{
		// Token: 0x060309D6 RID: 199126 RVA: 0x006999CC File Offset: 0x00697BCC
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

		// Token: 0x020085DC RID: 34268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014991 RID: 84369
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014992 RID: 84370
			public static VerifyTableAction <1>__Verify;
		}
	}
}
