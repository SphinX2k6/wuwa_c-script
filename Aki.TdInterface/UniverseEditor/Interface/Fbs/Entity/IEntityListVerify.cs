using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047AD RID: 18349
	public static class IEntityListVerify
	{
		// Token: 0x0601C50C RID: 115980 RVA: 0x0040215C File Offset: 0x0040035C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityListVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListElementVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079F8 RID: 31224
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A6 RID: 78758
			public static VerifyTableAction <0>__Verify;
		}
	}
}
