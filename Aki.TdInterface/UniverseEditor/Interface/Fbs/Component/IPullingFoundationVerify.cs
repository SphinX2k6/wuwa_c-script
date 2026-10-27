using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B0 RID: 22448
	public static class IPullingFoundationVerify
	{
		// Token: 0x06025AD5 RID: 154325 RVA: 0x00532744 File Offset: 0x00530944
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPullingFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPullingFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(IPullingCategoryMatchingFoundationVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BED RID: 31725
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136B6 RID: 79542
			public static VerifyTableAction <0>__Verify;
		}
	}
}
