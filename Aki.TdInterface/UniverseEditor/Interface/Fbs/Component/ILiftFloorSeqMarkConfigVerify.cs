using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8B RID: 23179
	public static class ILiftFloorSeqMarkConfigVerify
	{
		// Token: 0x06025FDE RID: 155614 RVA: 0x00535390 File Offset: 0x00533590
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILiftFloorSeqMarkConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiftFloorSeqMarkConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILiftFloorSeqMarkVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083E6 RID: 33766
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014691 RID: 83601
			public static VerifyTableAction <0>__Verify;
		}
	}
}
