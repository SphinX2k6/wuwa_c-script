using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550B RID: 21771
	public static class ILocationSafetyComponentVerify
	{
		// Token: 0x06023F5A RID: 147290 RVA: 0x004F8830 File Offset: 0x004F6A30
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

		// Token: 0x02007B88 RID: 31624
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401360C RID: 79372
			public static VerifyTableAction <0>__Verify;
		}
	}
}
