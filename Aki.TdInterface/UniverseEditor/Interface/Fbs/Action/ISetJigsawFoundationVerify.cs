using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D2 RID: 30674
	public static class ISetJigsawFoundationVerify
	{
		// Token: 0x06035E26 RID: 220710 RVA: 0x00738349 File Offset: 0x00736549
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

		// Token: 0x020086D3 RID: 34515
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AD9 RID: 84697
			public static VerifyTableAction <0>__Verify;
		}
	}
}
