using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB3 RID: 28595
	public static class ISetAudioEnableVerify
	{
		// Token: 0x060328A4 RID: 207012 RVA: 0x006D2070 File Offset: 0x006D0270
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetAudioEnableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAudioEnableVerify.<>O.<0>__Verify = new VerifyTableAction(IRoleSceneVoiceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E30 RID: 32304
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139EE RID: 80366
			public static VerifyTableAction <0>__Verify;
		}
	}
}
