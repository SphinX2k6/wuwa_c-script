using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4F RID: 27983
	public static class IPlotAudioConfigVerify
	{
		// Token: 0x0603169A RID: 202394 RVA: 0x006B35F9 File Offset: 0x006B17F9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlotAudioConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotAudioConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPlotVoiceFadeOutOnInterruptVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DFE RID: 32254
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139B9 RID: 80313
			public static VerifyTableAction <0>__Verify;
		}
	}
}
