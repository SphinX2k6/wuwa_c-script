using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E89 RID: 16009
	public static class IHandInGroupVerify
	{
		// Token: 0x06016939 RID: 92473 RVA: 0x0034307C File Offset: 0x0034127C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHandInGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandInGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IHandInItemRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F2 RID: 30962
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131AC RID: 78252
			public static VerifyTableAction <0>__Verify;
		}
	}
}
