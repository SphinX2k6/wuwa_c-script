using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B94 RID: 19348
	public static class ICameraFlowTemplateConfigVerify
	{
		// Token: 0x0601D7C7 RID: 120775 RVA: 0x00423D29 File Offset: 0x00421F29
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraFlowTemplateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraFlowTemplateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraTemplateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008227 RID: 33319
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143EC RID: 82924
			public static VerifyTableAction <0>__Verify;
		}
	}
}
