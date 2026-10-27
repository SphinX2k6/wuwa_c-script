using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F0 RID: 21744
	public static class ILevelSequenceFrameEventComponentVerify
	{
		// Token: 0x06023E22 RID: 146978 RVA: 0x004F61B0 File Offset: 0x004F43B0
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

		// Token: 0x02007B84 RID: 31620
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013607 RID: 79367
			public static VerifyTableAction <0>__Verify;
		}
	}
}
