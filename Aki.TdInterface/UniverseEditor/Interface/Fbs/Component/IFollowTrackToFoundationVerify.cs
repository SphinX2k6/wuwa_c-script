using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581F RID: 22559
	public static class IFollowTrackToFoundationVerify
	{
		// Token: 0x06024814 RID: 149524 RVA: 0x00503F48 File Offset: 0x00502148
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowTrackToFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowTrackToFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200838C RID: 33676
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145EF RID: 83439
			public static VerifyTableAction <0>__Verify;
		}
	}
}
