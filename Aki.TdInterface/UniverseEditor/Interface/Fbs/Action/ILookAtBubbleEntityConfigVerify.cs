using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717D RID: 29053
	public static class ILookAtBubbleEntityConfigVerify
	{
		// Token: 0x06032801 RID: 206849 RVA: 0x006D3344 File Offset: 0x006D1544
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILookAtBubbleEntityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILookAtBubbleEntityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityLookAtPerformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008622 RID: 34338
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149F0 RID: 84464
			public static VerifyTableAction <0>__Verify;
		}
	}
}
