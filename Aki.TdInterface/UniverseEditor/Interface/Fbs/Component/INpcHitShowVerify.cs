using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005625 RID: 22053
	public static class INpcHitShowVerify
	{
		// Token: 0x060249AE RID: 149934 RVA: 0x0050CC7C File Offset: 0x0050AE7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcHitShowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcHitShowVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BAA RID: 31658
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013641 RID: 79425
			public static VerifyTableAction <0>__Verify;
		}
	}
}
