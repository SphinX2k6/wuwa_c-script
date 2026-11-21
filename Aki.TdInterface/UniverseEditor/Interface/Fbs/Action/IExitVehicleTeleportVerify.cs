using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB7 RID: 28087
	public static class IExitVehicleTeleportVerify
	{
		// Token: 0x060307B0 RID: 198576 RVA: 0x00695D28 File Offset: 0x00693F28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExitVehicleTeleportVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExitVehicleTeleportVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExitVehicleTeleportVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IExitVehicleTeleportVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020085D6 RID: 34262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401498A RID: 84362
			public static VerifyTableAction <0>__Verify;
		}
	}
}
