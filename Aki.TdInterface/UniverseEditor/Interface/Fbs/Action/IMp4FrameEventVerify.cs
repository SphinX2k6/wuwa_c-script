using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C4 RID: 29380
	public static class IMp4FrameEventVerify
	{
		// Token: 0x0603338A RID: 209802 RVA: 0x006E9328 File Offset: 0x006E7528
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

		// Token: 0x0200864A RID: 34378
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A24 RID: 84516
			public static VerifyTableAction <0>__Verify;
		}
	}
}
