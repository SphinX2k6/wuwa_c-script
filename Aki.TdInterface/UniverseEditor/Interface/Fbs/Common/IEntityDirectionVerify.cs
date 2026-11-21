using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E5 RID: 25573
	public static class IEntityDirectionVerify
	{
		// Token: 0x0602B723 RID: 177955 RVA: 0x005EB634 File Offset: 0x005E9834
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008517 RID: 34071
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014879 RID: 84089
			public static VerifyTableAction <0>__Verify;
		}
	}
}
