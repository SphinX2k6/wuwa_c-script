using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F85 RID: 20357
	public static class ICheckJigsawItemPlaceIndexVerify
	{
		// Token: 0x0601FB52 RID: 129874 RVA: 0x00468558 File Offset: 0x00466758
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckJigsawItemPlaceIndexVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckJigsawItemPlaceIndexVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200828D RID: 33421
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401446F RID: 83055
			public static VerifyTableAction <0>__Verify;
		}
	}
}
