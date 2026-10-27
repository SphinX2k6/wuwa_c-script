using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006375 RID: 25461
	public static class IClaimDynamicEntityRewardVerify
	{
		// Token: 0x0602C0B5 RID: 180405 RVA: 0x0060D0FD File Offset: 0x0060B2FD
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

		// Token: 0x02007D18 RID: 32024
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401387F RID: 79999
			public static VerifyTableAction <0>__Verify;
		}
	}
}
