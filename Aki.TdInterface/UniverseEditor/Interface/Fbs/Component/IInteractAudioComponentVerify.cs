using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BF RID: 22975
	public static class IInteractAudioComponentVerify
	{
		// Token: 0x06025772 RID: 153458 RVA: 0x00523628 File Offset: 0x00521828
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

		// Token: 0x020083C8 RID: 33736
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014653 RID: 83539
			public static VerifyTableAction <0>__Verify;
		}
	}
}
