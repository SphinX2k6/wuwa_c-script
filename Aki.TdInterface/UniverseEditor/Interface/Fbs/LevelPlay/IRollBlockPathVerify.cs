using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A7 RID: 17831
	public static class IRollBlockPathVerify
	{
		// Token: 0x0601AF4E RID: 110414 RVA: 0x003D8548 File Offset: 0x003D6748
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockPathVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockPathVerify.<>O.<0>__Verify = new VerifyTableAction(IRollBlockPathNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C4 RID: 31172
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401335F RID: 78687
			public static VerifyTableAction <0>__Verify;
		}
	}
}
