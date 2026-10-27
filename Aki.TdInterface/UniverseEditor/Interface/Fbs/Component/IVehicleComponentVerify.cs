using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0D RID: 23309
	public static class IVehicleComponentVerify
	{
		// Token: 0x06027D35 RID: 163125 RVA: 0x0057A578 File Offset: 0x00578778
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVehicleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleTypedMotorConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IVehicleComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVehicleComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IPassengerTeleportConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 18, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 2UL, 2UL, false))
					{
						short offsetId3 = 26;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IVehicleComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IVehicleComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IVehiclePassengerConfigVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C74 RID: 31860
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013794 RID: 79764
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013795 RID: 79765
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013796 RID: 79766
			public static VerifyTableAction <2>__Verify;
		}
	}
}
