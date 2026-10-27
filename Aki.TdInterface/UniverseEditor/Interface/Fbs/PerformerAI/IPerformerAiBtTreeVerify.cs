using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200435C RID: 17244
	public static class IPerformerAiBtTreeVerify
	{
		// Token: 0x06019923 RID: 104739 RVA: 0x003A9158 File Offset: 0x003A7358
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPerformerAiBtTreeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerAiBtTreeVerify.<>O.<0>__Verify = new VerifyTableAction(IPerformerAiStartVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007986 RID: 31110
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013304 RID: 78596
			public static VerifyTableAction <0>__Verify;
		}
	}
}
