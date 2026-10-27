using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005529 RID: 21801
	public static class IMatchTargetChargingDeviceVerify
	{
		// Token: 0x06024060 RID: 147552 RVA: 0x004FA43C File Offset: 0x004F863C
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

		// Token: 0x02007B8B RID: 31627
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401360F RID: 79375
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013610 RID: 79376
			public static VerifyTableAction <1>__Verify;
		}
	}
}
