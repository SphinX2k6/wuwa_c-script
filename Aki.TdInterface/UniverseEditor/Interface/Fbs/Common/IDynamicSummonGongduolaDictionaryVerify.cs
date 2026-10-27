using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D90 RID: 23952
	public static class IDynamicSummonGongduolaDictionaryVerify
	{
		// Token: 0x06028FCF RID: 167887 RVA: 0x005A13D9 File Offset: 0x0059F5D9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSummonGongduolaDictionaryVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSummonGongduolaDictionaryVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicSummonGongduolaConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CA4 RID: 31908
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D1 RID: 79825
			public static VerifyTableAction <0>__Verify;
		}
	}
}
