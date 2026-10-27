using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005128 RID: 20776
	public static class IElementalBoxFoundationComponentVerify
	{
		// Token: 0x060217F8 RID: 137208 RVA: 0x004A6870 File Offset: 0x004A4A70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IElementalBoxFoundationComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalBoxFoundationComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IElementalBoxFoundationComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IElementalBoxFoundationComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AED RID: 31469
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013508 RID: 79112
			public static VerifyTableAction <0>__Verify;
		}
	}
}
