using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005846 RID: 22598
	public static class IFrequencyPaintComponentVerify
	{
		// Token: 0x060249BA RID: 149946 RVA: 0x00507AE4 File Offset: 0x00505CE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFrequencyPaintComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFrequencyPaintComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFrequencyPaintConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008395 RID: 33685
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145FD RID: 83453
			public static VerifyTableAction <0>__Verify;
		}
	}
}
