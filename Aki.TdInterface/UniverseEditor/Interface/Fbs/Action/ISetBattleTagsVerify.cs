using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778B RID: 30603
	public static class ISetBattleTagsVerify
	{
		// Token: 0x06035B89 RID: 220041 RVA: 0x00732C78 File Offset: 0x00730E78
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

		// Token: 0x020086C9 RID: 34505
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC3 RID: 84675
			public static VerifyTableAction <0>__Verify;
		}
	}
}
