using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006001 RID: 24577
	public static class ISunSpiritBlockExtraRangeVerify
	{
		// Token: 0x060296BB RID: 169659 RVA: 0x005A7564 File Offset: 0x005A5764
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

		// Token: 0x020084B6 RID: 33974
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147E4 RID: 83940
			public static VerifyTableAction <0>__Verify;
		}
	}
}
