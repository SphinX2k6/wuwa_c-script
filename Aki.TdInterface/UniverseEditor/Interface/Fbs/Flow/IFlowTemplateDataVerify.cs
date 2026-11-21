using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA6 RID: 19366
	public static class IFlowTemplateDataVerify
	{
		// Token: 0x0601D8B7 RID: 121015 RVA: 0x00425DCC File Offset: 0x00423FCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowTemplateDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowTemplateDataVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlowTemplateDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFlowTemplateDataVerify.<>O.<1>__Verify = new VerifyTableAction(ICameraParamVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200822D RID: 33325
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F3 RID: 82931
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143F4 RID: 82932
			public static VerifyTableAction <1>__Verify;
		}
	}
}
