using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752E RID: 29998
	public static class IVehiclePlayPassengerVoiceVerify
	{
		// Token: 0x0603694A RID: 223562 RVA: 0x0076A650 File Offset: 0x00768850
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

		// Token: 0x02007EC6 RID: 32454
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C12 RID: 80914
			public static VerifyTableAction <0>__Verify;
		}
	}
}
