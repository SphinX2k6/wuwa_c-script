using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596E RID: 22894
	public static class IIgnoresCollisionCfgVerify
	{
		// Token: 0x06025522 RID: 152866 RVA: 0x0051F7C8 File Offset: 0x0051D9C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IIgnoresCollisionCfgVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IIgnoresCollisionCfgVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083C1 RID: 33729
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401464A RID: 83530
			public static VerifyTableAction <0>__Verify;
		}
	}
}
