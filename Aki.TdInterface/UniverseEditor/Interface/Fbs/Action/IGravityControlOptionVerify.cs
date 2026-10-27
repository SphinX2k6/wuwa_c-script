using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689C RID: 26780
	public static class IGravityControlOptionVerify
	{
		// Token: 0x0602EB55 RID: 191317 RVA: 0x0065E2DC File Offset: 0x0065C4DC
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

		// Token: 0x02007D83 RID: 32131
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401390A RID: 80138
			public static VerifyTableAction <0>__Verify;
		}
	}
}
