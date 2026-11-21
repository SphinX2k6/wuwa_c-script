using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A73 RID: 23155
	public static class ILevelQteComponentVerify
	{
		// Token: 0x06025EB2 RID: 155314 RVA: 0x00532C8C File Offset: 0x00530E8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelQteComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelQteComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISingleBtnQteVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083E2 RID: 33762
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401468C RID: 83596
			public static VerifyTableAction <0>__Verify;
		}
	}
}
