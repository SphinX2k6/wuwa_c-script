using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007674 RID: 30324
	public static class IRogueSelectRoomVerify
	{
		// Token: 0x0603533E RID: 217918 RVA: 0x007240DD File Offset: 0x007222DD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRogueSelectRoomVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRogueSelectRoomVerify.<>O.<0>__Verify = new VerifyTableAction(IRogueRoleSelectRoomVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086A8 RID: 34472
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A9C RID: 84636
			public static VerifyTableAction <0>__Verify;
		}
	}
}
