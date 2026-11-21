using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C89 RID: 23689
	public static class IPasserbyNpcLiftMoveVerify
	{
		// Token: 0x060274C0 RID: 160960 RVA: 0x00561938 File Offset: 0x0055FB38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcLiftMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcLiftMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200842E RID: 33838
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401470E RID: 83726
			public static VerifyTableAction <0>__Verify;
		}
	}
}
