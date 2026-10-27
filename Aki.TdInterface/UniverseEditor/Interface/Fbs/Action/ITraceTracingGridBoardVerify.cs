using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742F RID: 29743
	public static class ITraceTracingGridBoardVerify
	{
		// Token: 0x06036093 RID: 221331 RVA: 0x00759A18 File Offset: 0x00757C18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITraceTracingGridBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITraceTracingGridBoardVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EA8 RID: 32424
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BEA RID: 80874
			public static VerifyTableAction <0>__Verify;
		}
	}
}
