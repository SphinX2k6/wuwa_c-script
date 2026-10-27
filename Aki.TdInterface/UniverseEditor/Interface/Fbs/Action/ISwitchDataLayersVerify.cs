using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724F RID: 29263
	public static class ISwitchDataLayersVerify
	{
		// Token: 0x06033E93 RID: 212627 RVA: 0x006FB918 File Offset: 0x006F9B18
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

		// Token: 0x02007E7A RID: 32378
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A5E RID: 80478
			public static VerifyTableAction <0>__Verify;
		}
	}
}
