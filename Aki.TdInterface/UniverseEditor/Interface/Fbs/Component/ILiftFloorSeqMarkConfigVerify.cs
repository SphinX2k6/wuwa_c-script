using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005505 RID: 21765
	public static class ILiftFloorSeqMarkConfigVerify
	{
		// Token: 0x06023F24 RID: 147236 RVA: 0x004F826C File Offset: 0x004F646C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILiftFloorSeqMarkConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiftFloorSeqMarkConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILiftFloorSeqMarkVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B87 RID: 31623
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401360B RID: 79371
			public static VerifyTableAction <0>__Verify;
		}
	}
}
