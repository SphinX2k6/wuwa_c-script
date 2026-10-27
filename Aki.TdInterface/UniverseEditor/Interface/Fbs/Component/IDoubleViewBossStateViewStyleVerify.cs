using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B3 RID: 20659
	public static class IDoubleViewBossStateViewStyleVerify
	{
		// Token: 0x0602131A RID: 135962 RVA: 0x0049C8B8 File Offset: 0x0049AAB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDoubleViewBossStateViewStyleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDoubleViewBossStateViewStyleVerify.<>O.<0>__Verify = new VerifyTableAction(IMarkMainStateTextTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007ADC RID: 31452
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134E9 RID: 79081
			public static VerifyTableAction <0>__Verify;
		}
	}
}
