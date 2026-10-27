using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007456 RID: 29782
	public static class ITransitionPopupYuanChengArtTextVerify
	{
		// Token: 0x060361BE RID: 221630 RVA: 0x0075BA64 File Offset: 0x00759C64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITransitionPopupYuanChengArtTextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITransitionPopupYuanChengArtTextVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EAC RID: 32428
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BEE RID: 80878
			public static VerifyTableAction <0>__Verify;
		}
	}
}
