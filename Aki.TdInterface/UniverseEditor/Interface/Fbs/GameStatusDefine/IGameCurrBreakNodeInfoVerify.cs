using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F3 RID: 18163
	public static class IGameCurrBreakNodeInfoVerify
	{
		// Token: 0x0601BCD0 RID: 113872 RVA: 0x003F0D78 File Offset: 0x003EEF78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGameCurrBreakNodeInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGameCurrBreakNodeInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IGameCurrBreakNodeInfo_RefVarsVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079D4 RID: 31188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013372 RID: 78706
			public static VerifyTableAction <0>__Verify;
		}
	}
}
