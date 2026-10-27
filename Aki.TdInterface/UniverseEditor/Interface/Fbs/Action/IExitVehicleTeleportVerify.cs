using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006737 RID: 26423
	public static class IExitVehicleTeleportVerify
	{
		// Token: 0x0602DF6A RID: 188266 RVA: 0x006485E4 File Offset: 0x006467E4
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

		// Token: 0x02007D5F RID: 32095
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138DE RID: 80094
			public static VerifyTableAction <0>__Verify;
		}
	}
}
