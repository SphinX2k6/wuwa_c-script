using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200643F RID: 25663
	public static class IGravityDirectionVectorInfoVerify
	{
		// Token: 0x0602B9A5 RID: 178597 RVA: 0x005EF924 File Offset: 0x005EDB24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGravityDirectionVectorInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGravityDirectionVectorInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200851E RID: 34078
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014880 RID: 84096
			public static VerifyTableAction <0>__Verify;
		}
	}
}
