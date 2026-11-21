using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777F RID: 30591
	public static class ISetAudioStateVerify
	{
		// Token: 0x06035B1C RID: 219932 RVA: 0x00731EC9 File Offset: 0x007300C9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetAudioStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAudioStateVerify.<>O.<0>__Verify = new VerifyTableAction(IAudioStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086C6 RID: 34502
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC0 RID: 84672
			public static VerifyTableAction <0>__Verify;
		}
	}
}
