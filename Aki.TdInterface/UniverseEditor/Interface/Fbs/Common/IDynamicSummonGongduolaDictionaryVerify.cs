using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063CD RID: 25549
	public static class IDynamicSummonGongduolaDictionaryVerify
	{
		// Token: 0x0602B659 RID: 177753 RVA: 0x005EA109 File Offset: 0x005E8309
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

		// Token: 0x02008515 RID: 34069
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014877 RID: 84087
			public static VerifyTableAction <0>__Verify;
		}
	}
}
