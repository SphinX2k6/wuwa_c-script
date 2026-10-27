using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200512E RID: 20782
	public static class IElementalHolderComponentVerify
	{
		// Token: 0x0602184D RID: 137293 RVA: 0x004A7710 File Offset: 0x004A5910
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

		// Token: 0x02007AEF RID: 31471
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401350C RID: 79116
			public static VerifyTableAction <0>__Verify;
		}
	}
}
