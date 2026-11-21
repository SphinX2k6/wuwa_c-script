using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F9E RID: 24478
	public static class ISpringComponentVerify
	{
		// Token: 0x060292C9 RID: 168649 RVA: 0x0059F234 File Offset: 0x0059D434
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

		// Token: 0x020084A8 RID: 33960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C7 RID: 83911
			public static VerifyTableAction <0>__Verify;
		}
	}
}
