using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570F RID: 22287
	public static class IPatrolRangeVerify
	{
		// Token: 0x06025438 RID: 152632 RVA: 0x005243A8 File Offset: 0x005225A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BD0 RID: 31696
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013688 RID: 79496
			public static VerifyTableAction <0>__Verify;
		}
	}
}
