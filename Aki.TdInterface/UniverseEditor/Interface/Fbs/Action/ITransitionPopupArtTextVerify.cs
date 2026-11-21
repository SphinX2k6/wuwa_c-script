using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C31 RID: 31793
	public static class ITransitionPopupArtTextVerify
	{
		// Token: 0x060394EA RID: 234730 RVA: 0x007BD3C4 File Offset: 0x007BB5C4
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

		// Token: 0x02008744 RID: 34628
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC6 RID: 85190
			public static VerifyTableAction <0>__Verify;
		}
	}
}
