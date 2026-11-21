using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548F RID: 21647
	public static class ICategoryMatchingAnimationBaseVerify
	{
		// Token: 0x060220EA RID: 139498 RVA: 0x004B1D78 File Offset: 0x004AFF78
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

		// Token: 0x020082F5 RID: 33525
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144F8 RID: 83192
			public static VerifyTableAction <0>__Verify;
		}
	}
}
