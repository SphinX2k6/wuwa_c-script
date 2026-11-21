using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B71 RID: 31601
	public static class ITeleportToAndEnterVehicleVerify
	{
		// Token: 0x06038EA7 RID: 233127 RVA: 0x007B1AE1 File Offset: 0x007AFCE1
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

		// Token: 0x02008733 RID: 34611
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CAB RID: 85163
			public static VerifyTableAction <0>__Verify;
		}
	}
}
