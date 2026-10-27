using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050CB RID: 20683
	public static class IDurabilityStateConfigVerify
	{
		// Token: 0x0602145C RID: 136284 RVA: 0x0049F294 File Offset: 0x0049D494
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDurabilityStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDurabilityStateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDurabilityStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AE0 RID: 31456
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134F1 RID: 79089
			public static VerifyTableAction <0>__Verify;
		}
	}
}
