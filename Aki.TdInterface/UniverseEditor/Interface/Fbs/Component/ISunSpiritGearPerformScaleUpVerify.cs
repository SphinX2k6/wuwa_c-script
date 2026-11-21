using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006010 RID: 24592
	public static class ISunSpiritGearPerformScaleUpVerify
	{
		// Token: 0x06029735 RID: 169781 RVA: 0x005A838C File Offset: 0x005A658C
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

		// Token: 0x020084B9 RID: 33977
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147E7 RID: 83943
			public static VerifyTableAction <0>__Verify;
		}
	}
}
