using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F4 RID: 23028
	public static class ISunSpiritBlockExtraRangeVerify
	{
		// Token: 0x06027143 RID: 160067 RVA: 0x005605A0 File Offset: 0x0055E7A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISunSpiritBlockExtraRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISunSpiritBlockExtraRangeVerify.<>O.<0>__Verify = new VerifyTableAction(ICylinderTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C47 RID: 31815
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013740 RID: 79680
			public static VerifyTableAction <0>__Verify;
		}
	}
}
