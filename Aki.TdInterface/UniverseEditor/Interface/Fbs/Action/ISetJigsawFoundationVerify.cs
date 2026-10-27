using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007009 RID: 28681
	public static class ISetJigsawFoundationVerify
	{
		// Token: 0x06032BC0 RID: 207808 RVA: 0x006D8705 File Offset: 0x006D6905
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetJigsawFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetJigsawFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(ISetPieceStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E3E RID: 32318
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A08 RID: 80392
			public static VerifyTableAction <0>__Verify;
		}
	}
}
