using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006797 RID: 26519
	public static class IFadeOutScreenVerify
	{
		// Token: 0x0602E255 RID: 189013 RVA: 0x0064D920 File Offset: 0x0064BB20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFadeOutScreenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeOutScreenVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D68 RID: 32104
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138EA RID: 80106
			public static VerifyTableAction <0>__Verify;
		}
	}
}
