using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756F RID: 30063
	public static class IQteHourglassVerify
	{
		// Token: 0x06034B82 RID: 215938 RVA: 0x00716F2C File Offset: 0x0071512C
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

		// Token: 0x02008694 RID: 34452
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A87 RID: 84615
			public static VerifyTableAction <0>__Verify;
		}
	}
}
