using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC3 RID: 15811
	public static class ICustomPlaceholderBindingProgressVerify
	{
		// Token: 0x06016108 RID: 90376 RVA: 0x00330CB8 File Offset: 0x0032EEB8
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

		// Token: 0x020078CF RID: 30927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013170 RID: 78192
			public static VerifyTableAction <0>__Verify;
		}
	}
}
