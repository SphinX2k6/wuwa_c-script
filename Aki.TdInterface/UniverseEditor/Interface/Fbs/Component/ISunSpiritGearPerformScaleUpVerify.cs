using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A03 RID: 23043
	public static class ISunSpiritGearPerformScaleUpVerify
	{
		// Token: 0x060271BD RID: 160189 RVA: 0x005613C8 File Offset: 0x0055F5C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISunSpiritGearPerformScaleUpVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISunSpiritGearPerformScaleUpVerify.<>O.<0>__Verify = new VerifyTableAction(IScaleUpSpiritPerformConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C4A RID: 31818
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013743 RID: 79683
			public static VerifyTableAction <0>__Verify;
		}
	}
}
