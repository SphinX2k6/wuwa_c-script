using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E67 RID: 20071
	public static class IAdsorptionMatchingAnimationVerify
	{
		// Token: 0x0601F851 RID: 129105 RVA: 0x00463CE8 File Offset: 0x00461EE8
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

		// Token: 0x02007A72 RID: 31346
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401343F RID: 78911
			public static VerifyTableAction <0>__Verify;
		}
	}
}
