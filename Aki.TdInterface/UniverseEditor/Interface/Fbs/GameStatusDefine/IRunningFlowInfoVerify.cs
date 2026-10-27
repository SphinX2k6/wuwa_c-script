using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004705 RID: 18181
	public static class IRunningFlowInfoVerify
	{
		// Token: 0x0601BDF4 RID: 114164 RVA: 0x003F359C File Offset: 0x003F179C
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

		// Token: 0x020079D6 RID: 31190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013379 RID: 78713
			public static VerifyTableAction <0>__Verify;
		}
	}
}
