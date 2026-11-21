using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006132 RID: 24882
	public static class IVehicleGenerationConfigVerify
	{
		// Token: 0x0602A38D RID: 172941 RVA: 0x005C32FC File Offset: 0x005C14FC
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

		// Token: 0x020084E6 RID: 34022
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401483D RID: 84029
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401483E RID: 84030
			public static VerifyTableAction <1>__Verify;
		}
	}
}
