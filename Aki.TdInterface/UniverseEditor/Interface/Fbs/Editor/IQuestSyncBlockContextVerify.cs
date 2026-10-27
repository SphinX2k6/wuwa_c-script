using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A0 RID: 18592
	public static class IQuestSyncBlockContextVerify
	{
		// Token: 0x0601D04B RID: 118859 RVA: 0x00419508 File Offset: 0x00417708
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestSyncBlockContextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestSyncBlockContextVerify.<>O.<0>__Verify = new VerifyTableAction(ISyncBlockGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A13 RID: 31251
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D1 RID: 78801
			public static VerifyTableAction <0>__Verify;
		}
	}
}
