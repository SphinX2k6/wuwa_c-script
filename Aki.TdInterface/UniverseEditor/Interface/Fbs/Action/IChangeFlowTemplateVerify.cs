using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696F RID: 26991
	public static class IChangeFlowTemplateVerify
	{
		// Token: 0x0602E481 RID: 189569 RVA: 0x00651C58 File Offset: 0x0064FE58
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

		// Token: 0x0200857F RID: 34175
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014918 RID: 84248
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014919 RID: 84249
			public static VerifyTableAction <1>__Verify;
		}
	}
}
