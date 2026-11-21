using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BCD RID: 19405
	public static class ILevelPlayFixProcessorVerify
	{
		// Token: 0x0601DA0B RID: 121355 RVA: 0x00428A55 File Offset: 0x00426C55
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayFixProcessorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayFixProcessorVerify.<>O.<0>__Verify = new VerifyTableAction(IFixActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008236 RID: 33334
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014401 RID: 82945
			public static VerifyTableAction <0>__Verify;
		}
	}
}
