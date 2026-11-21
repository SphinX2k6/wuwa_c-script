using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A76 RID: 23158
	public static class ILevelSequenceFrameEventComponentVerify
	{
		// Token: 0x06025EDC RID: 155356 RVA: 0x005332D4 File Offset: 0x005314D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelSequenceFrameEventComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelSequenceFrameEventComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelSequenceSectionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelSequenceFrameEventComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ILevelSequenceFrameEventComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelSequenceSectionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083E3 RID: 33763
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401468D RID: 83597
			public static VerifyTableAction <0>__Verify;
		}
	}
}
