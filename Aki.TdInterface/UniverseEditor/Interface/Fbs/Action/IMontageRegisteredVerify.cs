using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723C RID: 29244
	public static class IMontageRegisteredVerify
	{
		// Token: 0x06032EA1 RID: 208545 RVA: 0x006DFBF0 File Offset: 0x006DDDF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontageRegisteredVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontageRegisteredVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008638 RID: 34360
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A0D RID: 84493
			public static VerifyTableAction <0>__Verify;
		}
	}
}
