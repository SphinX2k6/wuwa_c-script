using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F2A RID: 20266
	public static class IBuffAreaVerify
	{
		// Token: 0x0602011B RID: 131355 RVA: 0x004764F4 File Offset: 0x004746F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBuffAreaVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffAreaVerify.<>O.<0>__Verify = new VerifyTableAction(IBuffAreaStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A93 RID: 31379
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013473 RID: 78963
			public static VerifyTableAction <0>__Verify;
		}
	}
}
