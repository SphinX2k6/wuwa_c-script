using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B78 RID: 23416
	public static class IMovementPerformConfigVerify
	{
		// Token: 0x06026937 RID: 158007 RVA: 0x00548598 File Offset: 0x00546798
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMovementPerformConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMovementPerformConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleMontagePlayConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMovementPerformConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMovementPerformConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ISpeedEffectConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008400 RID: 33792
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146C1 RID: 83649
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146C2 RID: 83650
			public static VerifyTableAction <1>__Verify;
		}
	}
}
