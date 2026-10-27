using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B52 RID: 23378
	public static class IWaterElementalMatchVerify
	{
		// Token: 0x06027FCC RID: 163788 RVA: 0x0057F7EC File Offset: 0x0057D9EC
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

		// Token: 0x02007C79 RID: 31865
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401379E RID: 79774
			public static VerifyTableAction <0>__Verify;
		}
	}
}
