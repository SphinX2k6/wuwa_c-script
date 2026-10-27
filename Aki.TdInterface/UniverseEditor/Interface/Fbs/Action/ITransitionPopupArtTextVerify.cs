using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743E RID: 29758
	public static class ITransitionPopupArtTextVerify
	{
		// Token: 0x06036101 RID: 221441 RVA: 0x0075A698 File Offset: 0x00758898
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITransitionPopupArtTextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITransitionPopupArtTextVerify.<>O.<0>__Verify = new VerifyTableAction(ITransitionPopupYuanChengArtTextVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EAA RID: 32426
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BEC RID: 80876
			public static VerifyTableAction <0>__Verify;
		}
	}
}
