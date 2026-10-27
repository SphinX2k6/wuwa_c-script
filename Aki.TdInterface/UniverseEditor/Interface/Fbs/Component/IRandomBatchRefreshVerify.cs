using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E3 RID: 22499
	public static class IRandomBatchRefreshVerify
	{
		// Token: 0x06025CDF RID: 154847 RVA: 0x00536D10 File Offset: 0x00534F10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomBatchRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomBatchRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BF8 RID: 31736
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C5 RID: 79557
			public static VerifyTableAction <0>__Verify;
		}
	}
}
