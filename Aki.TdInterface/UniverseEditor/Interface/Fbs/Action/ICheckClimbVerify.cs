using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200635A RID: 25434
	public static class ICheckClimbVerify
	{
		// Token: 0x0602BFFC RID: 180220 RVA: 0x0060BCB4 File Offset: 0x00609EB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckClimbVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckClimbVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D15 RID: 32021
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401387A RID: 79994
			public static VerifyTableAction <0>__Verify;
		}
	}
}
