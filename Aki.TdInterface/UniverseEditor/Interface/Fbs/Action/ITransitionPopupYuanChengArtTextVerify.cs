using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C49 RID: 31817
	public static class ITransitionPopupYuanChengArtTextVerify
	{
		// Token: 0x060395A7 RID: 234919 RVA: 0x007BE790 File Offset: 0x007BC990
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

		// Token: 0x02008746 RID: 34630
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC8 RID: 85192
			public static VerifyTableAction <0>__Verify;
		}
	}
}
