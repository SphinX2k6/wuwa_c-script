using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005378 RID: 21368
	public static class IAdsorptionMatchingAnimationVerify
	{
		// Token: 0x0602149C RID: 136348 RVA: 0x00497D00 File Offset: 0x00495F00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdsorptionMatchingAnimationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdsorptionMatchingAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdsorptionMatchingAnimationVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdsorptionMatchingAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082C4 RID: 33476
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144AF RID: 83119
			public static VerifyTableAction <0>__Verify;
		}
	}
}
