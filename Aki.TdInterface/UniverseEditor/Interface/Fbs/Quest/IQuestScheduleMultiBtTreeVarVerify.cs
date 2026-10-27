using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200402D RID: 16429
	public static class IQuestScheduleMultiBtTreeVarVerify
	{
		// Token: 0x06017C39 RID: 97337 RVA: 0x0036DC10 File Offset: 0x0036BE10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleMultiBtTreeVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleMultiBtTreeVarVerify.<>O.<0>__Verify = new VerifyTableAction(IWordArtConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007939 RID: 31033
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401324C RID: 78412
			public static VerifyTableAction <0>__Verify;
		}
	}
}
