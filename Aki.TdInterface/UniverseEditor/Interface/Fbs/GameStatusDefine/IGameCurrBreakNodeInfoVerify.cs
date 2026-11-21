using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B5B RID: 19291
	public static class IGameCurrBreakNodeInfoVerify
	{
		// Token: 0x0601D4A5 RID: 119973 RVA: 0x0041D014 File Offset: 0x0041B214
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

		// Token: 0x0200821D RID: 33309
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D9 RID: 82905
			public static VerifyTableAction <0>__Verify;
		}
	}
}
