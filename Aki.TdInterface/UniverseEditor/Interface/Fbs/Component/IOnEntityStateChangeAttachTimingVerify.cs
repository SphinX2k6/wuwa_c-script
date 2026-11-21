using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3E RID: 23614
	public static class IOnEntityStateChangeAttachTimingVerify
	{
		// Token: 0x06027258 RID: 160344 RVA: 0x0055D2CC File Offset: 0x0055B4CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOnEntityStateChangeAttachTimingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOnEntityStateChangeAttachTimingVerify.<>O.<0>__Verify = new VerifyTableAction(IAttachTimingEntityStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008425 RID: 33829
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014703 RID: 83715
			public static VerifyTableAction <0>__Verify;
		}
	}
}
