using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052BD RID: 21181
	public static class IForwardFrontReboundVerify
	{
		// Token: 0x06022890 RID: 141456 RVA: 0x004C9494 File Offset: 0x004C7694
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IForwardFrontReboundVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IForwardFrontReboundVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B31 RID: 31537
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401356F RID: 79215
			public static VerifyTableAction <0>__Verify;
		}
	}
}
