using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200471A RID: 18202
	public static class Record_String_IRunningFlowInfoVerify
	{
		// Token: 0x0601BF2A RID: 114474 RVA: 0x003F61B0 File Offset: 0x003F43B0
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

		// Token: 0x020079DA RID: 31194
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013381 RID: 78721
			public static VerifyTableAction <0>__Verify;
		}
	}
}
