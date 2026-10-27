using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E0 RID: 22496
	public static class IRandomBatchPoolRefreshVerify
	{
		// Token: 0x06025CC3 RID: 154819 RVA: 0x00536944 File Offset: 0x00534B44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomBatchPoolRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomBatchPoolRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BF7 RID: 31735
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C4 RID: 79556
			public static VerifyTableAction <0>__Verify;
		}
	}
}
