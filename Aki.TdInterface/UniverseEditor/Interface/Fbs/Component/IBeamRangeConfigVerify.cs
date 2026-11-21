using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005441 RID: 21569
	public static class IBeamRangeConfigVerify
	{
		// Token: 0x06021D43 RID: 138563 RVA: 0x004A9CC4 File Offset: 0x004A7EC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBeamRangeConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBeamRangeConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082E4 RID: 33508
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144E2 RID: 83170
			public static VerifyTableAction <0>__Verify;
		}
	}
}
