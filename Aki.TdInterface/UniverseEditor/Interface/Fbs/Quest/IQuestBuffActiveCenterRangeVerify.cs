using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200440B RID: 17419
	public static class IQuestBuffActiveCenterRangeVerify
	{
		// Token: 0x06018D59 RID: 101721 RVA: 0x0038AA68 File Offset: 0x00388C68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestBuffActiveCenterRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestBuffActiveCenterRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200816B RID: 33131
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401427F RID: 82559
			public static VerifyTableAction <0>__Verify;
		}
	}
}
