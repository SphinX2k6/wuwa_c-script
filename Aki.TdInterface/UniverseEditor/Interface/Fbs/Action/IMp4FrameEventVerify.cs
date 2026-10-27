using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7E RID: 27518
	public static class IMp4FrameEventVerify
	{
		// Token: 0x06030532 RID: 197938 RVA: 0x00690D08 File Offset: 0x0068EF08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMp4FrameEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMp4FrameEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DC2 RID: 32194
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013965 RID: 80229
			public static VerifyTableAction <0>__Verify;
		}
	}
}
