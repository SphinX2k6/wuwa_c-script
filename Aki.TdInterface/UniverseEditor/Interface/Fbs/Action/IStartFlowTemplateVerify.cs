using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007985 RID: 31109
	public static class IStartFlowTemplateVerify
	{
		// Token: 0x06036CB9 RID: 224441 RVA: 0x00754470 File Offset: 0x00752670
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStartFlowTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStartFlowTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowTemplateModeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStartFlowTemplateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStartFlowTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(IPosAVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008705 RID: 34565
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B24 RID: 84772
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B25 RID: 84773
			public static VerifyTableAction <1>__Verify;
		}
	}
}
