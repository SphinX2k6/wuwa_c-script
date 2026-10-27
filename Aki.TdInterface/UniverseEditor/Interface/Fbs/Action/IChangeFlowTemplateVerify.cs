using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062FE RID: 25342
	public static class IChangeFlowTemplateVerify
	{
		// Token: 0x0602BD18 RID: 179480 RVA: 0x00606C4C File Offset: 0x00604E4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeFlowTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeFlowTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowTemplateModeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IChangeFlowTemplateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IChangeFlowTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(IPosAVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D0C RID: 32012
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401386F RID: 79983
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013870 RID: 79984
			public static VerifyTableAction <1>__Verify;
		}
	}
}
