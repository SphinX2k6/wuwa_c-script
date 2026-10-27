using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AB RID: 29611
	public static class ITeleportTransitionWithCenterTextVerify
	{
		// Token: 0x06035C1A RID: 220186 RVA: 0x00751324 File Offset: 0x0074F524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportTransitionWithCenterTextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportTransitionWithCenterTextVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E9D RID: 32413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BD6 RID: 80854
			public static VerifyTableAction <0>__Verify;
		}
	}
}
