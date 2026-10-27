using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004559 RID: 17753
	public static class IRollBlockBoardConfigVerify
	{
		// Token: 0x0601AB9E RID: 109470 RVA: 0x003CFC24 File Offset: 0x003CDE24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockBoardConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockBoardConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B6 RID: 31158
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013351 RID: 78673
			public static VerifyTableAction <0>__Verify;
		}
	}
}
