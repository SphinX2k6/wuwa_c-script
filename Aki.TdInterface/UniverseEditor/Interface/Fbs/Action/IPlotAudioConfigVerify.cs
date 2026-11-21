using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CA RID: 29898
	public static class IPlotAudioConfigVerify
	{
		// Token: 0x06034696 RID: 214678 RVA: 0x0070ECE1 File Offset: 0x0070CEE1
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

		// Token: 0x0200868A RID: 34442
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A7D RID: 84605
			public static VerifyTableAction <0>__Verify;
		}
	}
}
