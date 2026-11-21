using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047BE RID: 18366
	public static class IPerformerAiBtTreeVerify
	{
		// Token: 0x0601B0B1 RID: 110769 RVA: 0x003D4B80 File Offset: 0x003D2D80
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

		// Token: 0x020081CF RID: 33231
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401436B RID: 82795
			public static VerifyTableAction <0>__Verify;
		}
	}
}
