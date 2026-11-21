using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005693 RID: 22163
	public static class IElementalHolderComponentVerify
	{
		// Token: 0x060237A1 RID: 145313 RVA: 0x004E169C File Offset: 0x004DF89C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IElementalHolderComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalHolderComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IElementalAbilityConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008349 RID: 33609
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401458A RID: 83338
			public static VerifyTableAction <0>__Verify;
		}
	}
}
