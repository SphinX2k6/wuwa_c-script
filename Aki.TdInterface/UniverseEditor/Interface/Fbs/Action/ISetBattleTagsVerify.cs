using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC2 RID: 28610
	public static class ISetBattleTagsVerify
	{
		// Token: 0x06032923 RID: 207139 RVA: 0x006D3034 File Offset: 0x006D1234
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetBattleTagsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetBattleTagsVerify.<>O.<0>__Verify = new VerifyTableAction(ISetBattleTagConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E34 RID: 32308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F2 RID: 80370
			public static VerifyTableAction <0>__Verify;
		}
	}
}
