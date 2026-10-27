using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B0 RID: 29104
	public static class IStartFlowTemplateVerify
	{
		// Token: 0x060339BB RID: 211387 RVA: 0x006F31A4 File Offset: 0x006F13A4
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

		// Token: 0x02007E6E RID: 32366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A4D RID: 80461
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A4E RID: 80462
			public static VerifyTableAction <1>__Verify;
		}
	}
}
