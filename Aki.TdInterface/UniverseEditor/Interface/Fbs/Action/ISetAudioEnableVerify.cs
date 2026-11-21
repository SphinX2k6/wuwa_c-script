using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777C RID: 30588
	public static class ISetAudioEnableVerify
	{
		// Token: 0x06035B0A RID: 219914 RVA: 0x00731CB4 File Offset: 0x0072FEB4
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

		// Token: 0x020086C5 RID: 34501
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ABF RID: 84671
			public static VerifyTableAction <0>__Verify;
		}
	}
}
