using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C6 RID: 29638
	public static class ITeleportVehicleVerify
	{
		// Token: 0x06035D4D RID: 220493 RVA: 0x00753EB8 File Offset: 0x007520B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITeleportVehicleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportVehicleVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleportVehicleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleportVehicleVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITeleportVehicleVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ITeleportVehicleVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							short typeIdVOffset2 = 16;
							short valueVOffset2 = 18;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = ITeleportVehicleVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (ITeleportVehicleVerify.<>O.<2>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction4, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007EA1 RID: 32417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BDF RID: 80863
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013BE0 RID: 80864
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013BE1 RID: 80865
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
