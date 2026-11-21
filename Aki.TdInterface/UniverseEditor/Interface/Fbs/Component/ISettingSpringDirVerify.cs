using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F14 RID: 24340
	public static class ISettingSpringDirVerify
	{
		// Token: 0x06028DAF RID: 167343 RVA: 0x005953E0 File Offset: 0x005935E0
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

		// Token: 0x02008499 RID: 33945
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147B2 RID: 83890
			public static VerifyTableAction <0>__Verify;
		}
	}
}
