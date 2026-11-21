using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540E RID: 21518
	public static class IAudioVehicleFeatureVerify
	{
		// Token: 0x06021A78 RID: 137848 RVA: 0x004A387C File Offset: 0x004A1A7C
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

		// Token: 0x020082DA RID: 33498
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144CD RID: 83149
			public static VerifyTableAction <0>__Verify;
		}
	}
}
