using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005738 RID: 22328
	public static class IPickInteractComponentVerify
	{
		// Token: 0x06025628 RID: 153128 RVA: 0x005288C4 File Offset: 0x00526AC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPickInteractComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPickInteractComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IChessmanPickInteractionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BD7 RID: 31703
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013696 RID: 79510
			public static VerifyTableAction <0>__Verify;
		}
	}
}
