using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E9B RID: 16027
	public static class IInformationBoardConfigVerify
	{
		// Token: 0x06016A13 RID: 92691 RVA: 0x00344DD5 File Offset: 0x00342FD5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInformationBoardConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInformationBoardConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDangoAbyssInformationBoardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F5 RID: 30965
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B2 RID: 78258
			public static VerifyTableAction <0>__Verify;
		}
	}
}
