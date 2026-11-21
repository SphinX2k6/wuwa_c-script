using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D05 RID: 19717
	public static class IQuestSyncBlockContextVerify
	{
		// Token: 0x0601E838 RID: 124984 RVA: 0x00445CA4 File Offset: 0x00443EA4
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

		// Token: 0x0200825C RID: 33372
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014437 RID: 82999
			public static VerifyTableAction <0>__Verify;
		}
	}
}
