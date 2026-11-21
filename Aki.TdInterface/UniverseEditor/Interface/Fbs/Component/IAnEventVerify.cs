using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C6 RID: 21446
	public static class IAnEventVerify
	{
		// Token: 0x060217BE RID: 137150 RVA: 0x0049E348 File Offset: 0x0049C548
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAnEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAnEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082D0 RID: 33488
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144BF RID: 83135
			public static VerifyTableAction <0>__Verify;
		}
	}
}
