using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200509E RID: 20638
	public static class IDollGrabInfiniteStageConfigVerify
	{
		// Token: 0x0602123A RID: 135738 RVA: 0x0049ACEC File Offset: 0x00498EEC
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

		// Token: 0x02007AD8 RID: 31448
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134E2 RID: 79074
			public static VerifyTableAction <0>__Verify;
		}
	}
}
