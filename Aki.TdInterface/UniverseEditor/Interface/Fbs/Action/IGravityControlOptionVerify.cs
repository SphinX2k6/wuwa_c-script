using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3D RID: 28477
	public static class IGravityControlOptionVerify
	{
		// Token: 0x0603148F RID: 201871 RVA: 0x006AD35C File Offset: 0x006AB55C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGravityControlOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGravityControlOptionVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085FC RID: 34300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B9 RID: 84409
			public static VerifyTableAction <0>__Verify;
		}
	}
}
