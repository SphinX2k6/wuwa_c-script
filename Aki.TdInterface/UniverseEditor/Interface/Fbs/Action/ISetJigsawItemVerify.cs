using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DB RID: 30683
	public static class ISetJigsawItemVerify
	{
		// Token: 0x06035E56 RID: 220758 RVA: 0x007387B9 File Offset: 0x007369B9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetJigsawItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetJigsawItemVerify.<>O.<0>__Verify = new VerifyTableAction(IMoveJigsawItemVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086D4 RID: 34516
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ADA RID: 84698
			public static VerifyTableAction <0>__Verify;
		}
	}
}
