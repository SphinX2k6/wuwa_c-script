using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C3 RID: 22211
	public static class IEntityBatchRefreshModeVerify
	{
		// Token: 0x0602397F RID: 145791 RVA: 0x004E50D4 File Offset: 0x004E32D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityBatchRefreshModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityBatchRefreshModeVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008350 RID: 33616
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014594 RID: 83348
			public static VerifyTableAction <0>__Verify;
		}
	}
}
