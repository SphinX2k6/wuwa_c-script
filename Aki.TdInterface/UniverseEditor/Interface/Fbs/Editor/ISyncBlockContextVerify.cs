using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D11 RID: 19729
	public static class ISyncBlockContextVerify
	{
		// Token: 0x0601E89E RID: 125086 RVA: 0x00446760 File Offset: 0x00444960
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

		// Token: 0x0200825D RID: 33373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014438 RID: 83000
			public static VerifyTableAction <0>__Verify;
		}
	}
}
