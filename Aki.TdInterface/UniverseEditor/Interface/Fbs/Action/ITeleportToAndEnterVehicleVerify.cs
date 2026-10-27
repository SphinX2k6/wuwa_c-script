using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738A RID: 29578
	public static class ITeleportToAndEnterVehicleVerify
	{
		// Token: 0x06035B0C RID: 219916 RVA: 0x0074F5A1 File Offset: 0x0074D7A1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportToAndEnterVehicleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportToAndEnterVehicleVerify.<>O.<0>__Verify = new VerifyTableAction(ITeleportToAndEnterFishingBoatVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E9A RID: 32410
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BD2 RID: 80850
			public static VerifyTableAction <0>__Verify;
		}
	}
}
