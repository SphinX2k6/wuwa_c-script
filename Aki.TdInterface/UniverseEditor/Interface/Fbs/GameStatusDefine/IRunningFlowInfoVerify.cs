using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B6D RID: 19309
	public static class IRunningFlowInfoVerify
	{
		// Token: 0x0601D5C9 RID: 120265 RVA: 0x0041F838 File Offset: 0x0041DA38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningFlowInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningFlowInfoVerify.<>O.<0>__Verify = new VerifyTableAction(Record_Int_EActionStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200821F RID: 33311
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143E0 RID: 82912
			public static VerifyTableAction <0>__Verify;
		}
	}
}
