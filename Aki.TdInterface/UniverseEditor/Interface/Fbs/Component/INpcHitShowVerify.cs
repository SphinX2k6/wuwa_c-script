using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC3 RID: 23491
	public static class INpcHitShowVerify
	{
		// Token: 0x06026BBE RID: 158654 RVA: 0x0054D294 File Offset: 0x0054B494
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

		// Token: 0x0200840C RID: 33804
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146D0 RID: 83664
			public static VerifyTableAction <0>__Verify;
		}
	}
}
