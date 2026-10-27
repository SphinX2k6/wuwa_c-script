using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F60 RID: 20320
	public static class ICategoryMatchingAnimationBaseVerify
	{
		// Token: 0x06020398 RID: 131992 RVA: 0x0047BD88 File Offset: 0x00479F88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingAnimationBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingAnimationBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICategoryMatchingAnimationBaseVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICategoryMatchingAnimationBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 8, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A9F RID: 31391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013482 RID: 78978
			public static VerifyTableAction <0>__Verify;
		}
	}
}
