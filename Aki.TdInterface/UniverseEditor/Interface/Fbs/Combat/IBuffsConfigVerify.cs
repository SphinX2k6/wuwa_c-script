using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EE9 RID: 24297
	public static class IBuffsConfigVerify
	{
		// Token: 0x06029BA1 RID: 170913 RVA: 0x005BA001 File Offset: 0x005B8201
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBuffsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBuffConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CC2 RID: 31938
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F2 RID: 79858
			public static VerifyTableAction <0>__Verify;
		}
	}
}
