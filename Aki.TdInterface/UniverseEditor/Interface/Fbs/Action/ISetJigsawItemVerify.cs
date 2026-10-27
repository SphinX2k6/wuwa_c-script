using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007012 RID: 28690
	public static class ISetJigsawItemVerify
	{
		// Token: 0x06032BF0 RID: 207856 RVA: 0x006D8B75 File Offset: 0x006D6D75
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

		// Token: 0x02007E3F RID: 32319
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A09 RID: 80393
			public static VerifyTableAction <0>__Verify;
		}
	}
}
