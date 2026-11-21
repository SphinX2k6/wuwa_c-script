using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FC RID: 28924
	public static class ILiveInteractDanmakuListenerGroupVerify
	{
		// Token: 0x060323C8 RID: 205768 RVA: 0x006CB610 File Offset: 0x006C9810
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILiveInteractDanmakuListenerGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveInteractDanmakuListenerGroupVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiveInteractDanmakuTriggerVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008615 RID: 34325
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149DF RID: 84447
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
