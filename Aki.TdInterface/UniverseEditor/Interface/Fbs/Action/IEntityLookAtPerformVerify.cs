using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E3 RID: 26339
	public static class IEntityLookAtPerformVerify
	{
		// Token: 0x0602DCB6 RID: 187574 RVA: 0x006433F0 File Offset: 0x006415F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityLookAtPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityLookAtPerformVerify.<>O.<0>__Verify = new VerifyTableAction(ILookAtPerformOverlapMontageConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D54 RID: 32084
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D1 RID: 80081
			public static VerifyTableAction <0>__Verify;
		}
	}
}
