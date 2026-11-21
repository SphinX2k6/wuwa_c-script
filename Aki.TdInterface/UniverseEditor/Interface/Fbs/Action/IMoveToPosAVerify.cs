using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AB RID: 29355
	public static class IMoveToPosAVerify
	{
		// Token: 0x06033291 RID: 209553 RVA: 0x006E72A8 File Offset: 0x006E54A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveToPosAVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveToPosAVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008646 RID: 34374
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A1C RID: 84508
			public static VerifyTableAction <0>__Verify;
		}
	}
}
