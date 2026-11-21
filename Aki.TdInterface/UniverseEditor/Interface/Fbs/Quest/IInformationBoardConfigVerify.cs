using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D9 RID: 17113
	public static class IInformationBoardConfigVerify
	{
		// Token: 0x06018060 RID: 98400 RVA: 0x0036DD5D File Offset: 0x0036BF5D
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

		// Token: 0x0200813B RID: 33083
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014210 RID: 82448
			public static VerifyTableAction <0>__Verify;
		}
	}
}
