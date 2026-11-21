using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E08 RID: 28168
	public static class IFadeBackgroundUiPrefabVerify
	{
		// Token: 0x06030A0E RID: 199182 RVA: 0x00699F94 File Offset: 0x00698194
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

		// Token: 0x020085DD RID: 34269
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014993 RID: 84371
			public static VerifyTableAction <0>__Verify;
		}
	}
}
