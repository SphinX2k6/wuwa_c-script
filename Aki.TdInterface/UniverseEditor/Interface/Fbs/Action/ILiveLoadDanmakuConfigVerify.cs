using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007114 RID: 28948
	public static class ILiveLoadDanmakuConfigVerify
	{
		// Token: 0x060324A2 RID: 205986 RVA: 0x006CCE00 File Offset: 0x006CB000
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILiveLoadDanmakuConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveLoadDanmakuConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILiveDanmakuPoolVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008617 RID: 34327
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E1 RID: 84449
			public static VerifyTableAction <0>__Verify;
		}
	}
}
