using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FE RID: 16894
	public static class IDarkTideSystemConfigVerify
	{
		// Token: 0x06017727 RID: 96039 RVA: 0x003596B8 File Offset: 0x003578B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDarkTideSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDarkTideSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDarkTideBossEventModuleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008115 RID: 33045
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141CE RID: 82382
			public static VerifyTableAction <0>__Verify;
		}
	}
}
