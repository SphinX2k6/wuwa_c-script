using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B8 RID: 20920
	public static class IEntityStateAudioConfigVerify
	{
		// Token: 0x06021E0F RID: 138767 RVA: 0x004B2F44 File Offset: 0x004B1144
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityStateAudioConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateAudioConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IAudioFadeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B04 RID: 31492
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013529 RID: 79145
			public static VerifyTableAction <0>__Verify;
		}
	}
}
