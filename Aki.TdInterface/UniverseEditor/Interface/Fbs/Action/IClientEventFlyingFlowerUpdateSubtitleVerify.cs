using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200639F RID: 25503
	public static class IClientEventFlyingFlowerUpdateSubtitleVerify
	{
		// Token: 0x0602C1F2 RID: 180722 RVA: 0x0060F590 File Offset: 0x0060D790
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientEventFlyingFlowerUpdateSubtitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientEventFlyingFlowerUpdateSubtitleVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D1A RID: 32026
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013885 RID: 80005
			public static VerifyTableAction <0>__Verify;
		}
	}
}
