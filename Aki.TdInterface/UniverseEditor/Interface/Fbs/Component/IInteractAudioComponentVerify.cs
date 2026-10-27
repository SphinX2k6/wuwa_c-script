using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005439 RID: 21561
	public static class IInteractAudioComponentVerify
	{
		// Token: 0x060236BA RID: 145082 RVA: 0x004E65FC File Offset: 0x004E47FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractAudioComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractAudioComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IAudioEventConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B69 RID: 31593
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135CD RID: 79309
			public static VerifyTableAction <0>__Verify;
		}
	}
}
