using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063FF RID: 25599
	public static class IClientTeleportVehicleVerify
	{
		// Token: 0x0602C497 RID: 181399 RVA: 0x006140E8 File Offset: 0x006122E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientTeleportVehicleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientTeleportVehicleVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IClientTeleportVehicleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IClientTeleportVehicleVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IClientTeleportVehicleVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IClientTeleportVehicleVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D24 RID: 32036
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401388F RID: 80015
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013890 RID: 80016
			public static VerifyTableAction <1>__Verify;
		}
	}
}
