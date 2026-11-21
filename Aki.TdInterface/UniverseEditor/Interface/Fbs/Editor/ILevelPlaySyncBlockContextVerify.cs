using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CED RID: 19693
	public static class ILevelPlaySyncBlockContextVerify
	{
		// Token: 0x0601E75E RID: 124766 RVA: 0x004443BC File Offset: 0x004425BC
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

		// Token: 0x0200825B RID: 33371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014436 RID: 82998
			public static VerifyTableAction <0>__Verify;
		}
	}
}
