using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C22 RID: 31778
	public static class ITraceTracingGridBoardVerify
	{
		// Token: 0x0603947C RID: 234620 RVA: 0x007BC744 File Offset: 0x007BA944
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

		// Token: 0x02008742 RID: 34626
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC4 RID: 85188
			public static VerifyTableAction <0>__Verify;
		}
	}
}
