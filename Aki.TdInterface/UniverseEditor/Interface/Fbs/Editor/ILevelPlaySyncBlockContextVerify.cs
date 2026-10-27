using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004888 RID: 18568
	public static class ILevelPlaySyncBlockContextVerify
	{
		// Token: 0x0601CF71 RID: 118641 RVA: 0x00417C20 File Offset: 0x00415E20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlaySyncBlockContextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlaySyncBlockContextVerify.<>O.<0>__Verify = new VerifyTableAction(ISyncBlockGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A12 RID: 31250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D0 RID: 78800
			public static VerifyTableAction <0>__Verify;
		}
	}
}
