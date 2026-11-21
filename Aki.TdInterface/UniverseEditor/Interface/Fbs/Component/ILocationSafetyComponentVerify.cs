using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A91 RID: 23185
	public static class ILocationSafetyComponentVerify
	{
		// Token: 0x06026014 RID: 155668 RVA: 0x00535954 File Offset: 0x00533B54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILocationSafetyComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILocationSafetyComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083E7 RID: 33767
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014692 RID: 83602
			public static VerifyTableAction <0>__Verify;
		}
	}
}
