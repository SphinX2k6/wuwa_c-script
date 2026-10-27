using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1C RID: 23324
	public static class IVehicleGenerationConfigVerify
	{
		// Token: 0x06027DC9 RID: 163273 RVA: 0x0057B8A8 File Offset: 0x00579AA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVehicleGenerationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleGenerationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISplineWayPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IVehicleGenerationConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVehicleGenerationConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C75 RID: 31861
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013797 RID: 79767
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013798 RID: 79768
			public static VerifyTableAction <1>__Verify;
		}
	}
}
