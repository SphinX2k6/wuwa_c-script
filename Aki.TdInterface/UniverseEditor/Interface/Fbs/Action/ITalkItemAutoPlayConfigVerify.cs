using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A96 RID: 31382
	public static class ITalkItemAutoPlayConfigVerify
	{
		// Token: 0x060375F9 RID: 226809 RVA: 0x00765D45 File Offset: 0x00763F45
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemAutoPlayConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemAutoPlayConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkItemDisableAutoSelectOptionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008719 RID: 34585
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B4D RID: 84813
			public static VerifyTableAction <0>__Verify;
		}
	}
}
