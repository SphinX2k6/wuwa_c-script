using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063CA RID: 25546
	public static class IDynamicSummonGongduolaConfigVerify
	{
		// Token: 0x0602B641 RID: 177729 RVA: 0x005E9DC4 File Offset: 0x005E7FC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSummonGongduolaConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSummonGongduolaConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicSummonGongduolaPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008514 RID: 34068
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014876 RID: 84086
			public static VerifyTableAction <0>__Verify;
		}
	}
}
