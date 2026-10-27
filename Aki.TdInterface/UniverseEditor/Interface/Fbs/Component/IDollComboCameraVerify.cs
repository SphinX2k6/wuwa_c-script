using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005092 RID: 20626
	public static class IDollComboCameraVerify
	{
		// Token: 0x060211BA RID: 135610 RVA: 0x00499B34 File Offset: 0x00497D34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollComboCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollComboCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IDollComboCameraConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AD5 RID: 31445
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134DD RID: 79069
			public static VerifyTableAction <0>__Verify;
		}
	}
}
