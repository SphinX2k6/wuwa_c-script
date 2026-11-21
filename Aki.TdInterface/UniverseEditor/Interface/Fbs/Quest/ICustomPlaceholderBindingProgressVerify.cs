using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DA RID: 16858
	public static class ICustomPlaceholderBindingProgressVerify
	{
		// Token: 0x06017641 RID: 95809 RVA: 0x00358040 File Offset: 0x00356240
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICustomPlaceholderBindingProgressVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomPlaceholderBindingProgressVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerHavingItemCountVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008113 RID: 33043
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141CC RID: 82380
			public static VerifyTableAction <0>__Verify;
		}
	}
}
