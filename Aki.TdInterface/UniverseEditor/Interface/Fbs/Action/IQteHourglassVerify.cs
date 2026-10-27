using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF4 RID: 28148
	public static class IQteHourglassVerify
	{
		// Token: 0x06031B86 RID: 203654 RVA: 0x006BB844 File Offset: 0x006B9A44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQteHourglassVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQteHourglassVerify.<>O.<0>__Verify = new VerifyTableAction(IQteHourglassConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E08 RID: 32264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C3 RID: 80323
			public static VerifyTableAction <0>__Verify;
		}
	}
}
