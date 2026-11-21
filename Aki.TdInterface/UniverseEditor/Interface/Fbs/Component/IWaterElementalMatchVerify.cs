using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006168 RID: 24936
	public static class IWaterElementalMatchVerify
	{
		// Token: 0x0602A590 RID: 173456 RVA: 0x005C727C File Offset: 0x005C547C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaterElementalMatchVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaterElementalMatchVerify.<>O.<0>__Verify = new VerifyTableAction(IWaterStagnationActorConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084EA RID: 34026
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014844 RID: 84036
			public static VerifyTableAction <0>__Verify;
		}
	}
}
