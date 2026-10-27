using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB6 RID: 19126
	public static class ICheckJigsawItemPlaceIndexVerify
	{
		// Token: 0x0601E069 RID: 122985 RVA: 0x00436D38 File Offset: 0x00434F38
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

		// Token: 0x02007A3D RID: 31293
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013401 RID: 78849
			public static VerifyTableAction <0>__Verify;
		}
	}
}
