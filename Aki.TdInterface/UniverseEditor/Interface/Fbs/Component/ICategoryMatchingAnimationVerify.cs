using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548C RID: 21644
	public static class ICategoryMatchingAnimationVerify
	{
		// Token: 0x060220CE RID: 139470 RVA: 0x004B1974 File Offset: 0x004AFB74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingAnimationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICategoryMatchingAnimationVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICategoryMatchingAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICategoryMatchingAnimationVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ICategoryMatchingAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020082F4 RID: 33524
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144F7 RID: 83191
			public static VerifyTableAction <0>__Verify;
		}
	}
}
