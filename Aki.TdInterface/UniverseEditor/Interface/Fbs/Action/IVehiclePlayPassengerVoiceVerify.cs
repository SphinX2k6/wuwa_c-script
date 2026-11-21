using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D24 RID: 32036
	public static class IVehiclePlayPassengerVoiceVerify
	{
		// Token: 0x06039D60 RID: 236896 RVA: 0x007CD8F8 File Offset: 0x007CBAF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVehiclePlayPassengerVoiceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehiclePlayPassengerVoiceVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayVoicePassengersConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008760 RID: 34656
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CEC RID: 85228
			public static VerifyTableAction <0>__Verify;
		}
	}
}
