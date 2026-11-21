using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A24 RID: 31268
	public static class ISwitchDataLayersVerify
	{
		// Token: 0x06037195 RID: 225685 RVA: 0x0075CC78 File Offset: 0x0075AE78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISwitchDataLayersVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwitchDataLayersVerify.<>O.<0>__Verify = new VerifyTableAction(ISwitchDataLayersTransitionWithSequenceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008711 RID: 34577
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B35 RID: 84789
			public static VerifyTableAction <0>__Verify;
		}
	}
}
