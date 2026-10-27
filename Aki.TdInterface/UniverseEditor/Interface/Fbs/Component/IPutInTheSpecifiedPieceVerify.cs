using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BC RID: 22460
	public static class IPutInTheSpecifiedPieceVerify
	{
		// Token: 0x06025B21 RID: 154401 RVA: 0x00532EEC File Offset: 0x005310EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPutInTheSpecifiedPieceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPutInTheSpecifiedPieceVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawPieceMatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BEE RID: 31726
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136B7 RID: 79543
			public static VerifyTableAction <0>__Verify;
		}
	}
}
