using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF0 RID: 28400
	public static class IRogueSelectRoomVerify
	{
		// Token: 0x060322FE RID: 205566 RVA: 0x006C83A9 File Offset: 0x006C65A9
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

		// Token: 0x02007E1C RID: 32284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D8 RID: 80344
			public static VerifyTableAction <0>__Verify;
		}
	}
}
