using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAF RID: 23215
	public static class IMatchTargetChargingDeviceVerify
	{
		// Token: 0x0602611A RID: 155930 RVA: 0x00537560 File Offset: 0x00535760
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMatchTargetChargingDeviceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMatchTargetChargingDeviceVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					short offsetId2 = 20;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMatchTargetChargingDeviceVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMatchTargetChargingDeviceVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083EA RID: 33770
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014695 RID: 83605
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014696 RID: 83606
			public static VerifyTableAction <1>__Verify;
		}
	}
}
