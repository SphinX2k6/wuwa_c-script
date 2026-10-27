using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EDF RID: 20191
	public static class IAudioVehicleFeatureVerify
	{
		// Token: 0x0601FD34 RID: 130356 RVA: 0x0046DAAC File Offset: 0x0046BCAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAudioVehicleFeatureVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAudioVehicleFeatureVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleAudioConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A84 RID: 31364
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013457 RID: 78935
			public static VerifyTableAction <0>__Verify;
		}
	}
}
