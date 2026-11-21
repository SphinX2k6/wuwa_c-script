using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B82 RID: 19330
	public static class Record_String_IRunningFlowInfoVerify
	{
		// Token: 0x0601D6FF RID: 120575 RVA: 0x0042244C File Offset: 0x0042064C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_String_IRunningFlowInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_String_IRunningFlowInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IRunningFlowInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008223 RID: 33315
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143E8 RID: 82920
			public static VerifyTableAction <0>__Verify;
		}
	}
}
