using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DA RID: 21978
	public static class IMovementPerformConfigVerify
	{
		// Token: 0x0602472A RID: 149290 RVA: 0x00508020 File Offset: 0x00506220
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

		// Token: 0x02007B9E RID: 31646
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013632 RID: 79410
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013633 RID: 79411
			public static VerifyTableAction <1>__Verify;
		}
	}
}
