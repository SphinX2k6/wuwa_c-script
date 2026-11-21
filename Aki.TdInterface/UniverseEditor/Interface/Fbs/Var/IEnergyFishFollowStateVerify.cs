using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E73 RID: 15987
	public static class IEnergyFishFollowStateVerify
	{
		// Token: 0x060158E1 RID: 88289 RVA: 0x0031B7E4 File Offset: 0x003199E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnergyFishFollowStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnergyFishFollowStateVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B9 RID: 32953
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014138 RID: 82232
			public static VerifyTableAction <0>__Verify;
		}
	}
}
