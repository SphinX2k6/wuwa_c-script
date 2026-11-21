using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005603 RID: 22019
	public static class IDollGrabInfiniteStageConfigVerify
	{
		// Token: 0x0602318E RID: 143758 RVA: 0x004D4C78 File Offset: 0x004D2E78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollGrabInfiniteStageConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollGrabInfiniteStageConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDollGrabStageAudioStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008332 RID: 33586
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014560 RID: 83296
			public static VerifyTableAction <0>__Verify;
		}
	}
}
