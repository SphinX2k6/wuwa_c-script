using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048AC RID: 18604
	public static class ISyncBlockContextVerify
	{
		// Token: 0x0601D0B1 RID: 118961 RVA: 0x00419FC4 File Offset: 0x004181C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISyncBlockContextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISyncBlockContextVerify.<>O.<0>__Verify = new VerifyTableAction(ISyncBlockGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A14 RID: 31252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D2 RID: 78802
			public static VerifyTableAction <0>__Verify;
		}
	}
}
