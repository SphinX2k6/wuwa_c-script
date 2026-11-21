using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E6 RID: 27110
	public static class IClaimDynamicEntityRewardVerify
	{
		// Token: 0x0602E81F RID: 190495 RVA: 0x00658251 File Offset: 0x00656451
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClaimDynamicEntityRewardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClaimDynamicEntityRewardVerify.<>O.<0>__Verify = new VerifyTableAction(IClaimDynamicTrafficRewardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200858C RID: 34188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014929 RID: 84265
			public static VerifyTableAction <0>__Verify;
		}
	}
}
