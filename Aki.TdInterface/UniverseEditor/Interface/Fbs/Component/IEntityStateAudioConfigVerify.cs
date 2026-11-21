using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571D RID: 22301
	public static class IEntityStateAudioConfigVerify
	{
		// Token: 0x06023D67 RID: 146791 RVA: 0x004ECFAC File Offset: 0x004EB1AC
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

		// Token: 0x0200835E RID: 33630
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A7 RID: 83367
			public static VerifyTableAction <0>__Verify;
		}
	}
}
