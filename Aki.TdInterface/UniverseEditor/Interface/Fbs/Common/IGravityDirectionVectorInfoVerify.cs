using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E02 RID: 24066
	public static class IGravityDirectionVectorInfoVerify
	{
		// Token: 0x0602931B RID: 168731 RVA: 0x005A6BF4 File Offset: 0x005A4DF4
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

		// Token: 0x02007CAD RID: 31917
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137DA RID: 79834
			public static VerifyTableAction <0>__Verify;
		}
	}
}
