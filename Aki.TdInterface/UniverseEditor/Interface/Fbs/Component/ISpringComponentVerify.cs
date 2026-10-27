using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005991 RID: 22929
	public static class ISpringComponentVerify
	{
		// Token: 0x06026D5F RID: 159071 RVA: 0x005585C8 File Offset: 0x005567C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpringComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpringComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISettingSpringDirVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C39 RID: 31801
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013725 RID: 79653
			public static VerifyTableAction <0>__Verify;
		}
	}
}
