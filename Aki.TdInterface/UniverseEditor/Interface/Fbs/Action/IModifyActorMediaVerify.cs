using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EB RID: 29163
	public static class IModifyActorMediaVerify
	{
		// Token: 0x06032BB3 RID: 207795 RVA: 0x006DA49D File Offset: 0x006D869D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IModifyActorMediaVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMediaVerify.<>O.<0>__Verify = new VerifyTableAction(IChangeMediaPlayDaVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008630 RID: 34352
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A02 RID: 84482
			public static VerifyTableAction <0>__Verify;
		}
	}
}
