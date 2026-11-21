using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007749 RID: 30537
	public static class ISequenceFrameEventVerify
	{
		// Token: 0x06035951 RID: 219473 RVA: 0x0072E6DC File Offset: 0x0072C8DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceFrameEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceFrameEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086BC RID: 34492
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB5 RID: 84661
			public static VerifyTableAction <0>__Verify;
		}
	}
}
