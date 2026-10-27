using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005907 RID: 22791
	public static class ISettingSpringDirVerify
	{
		// Token: 0x06026845 RID: 157765 RVA: 0x0054E774 File Offset: 0x0054C974
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISettingSpringDirVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISettingSpringDirVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C2A RID: 31786
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013710 RID: 79632
			public static VerifyTableAction <0>__Verify;
		}
	}
}
