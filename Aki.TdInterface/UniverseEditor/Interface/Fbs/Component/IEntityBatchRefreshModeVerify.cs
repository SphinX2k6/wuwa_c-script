using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200515E RID: 20830
	public static class IEntityBatchRefreshModeVerify
	{
		// Token: 0x06021A2B RID: 137771 RVA: 0x004AB148 File Offset: 0x004A9348
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

		// Token: 0x02007AF6 RID: 31478
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013516 RID: 79126
			public static VerifyTableAction <0>__Verify;
		}
	}
}
