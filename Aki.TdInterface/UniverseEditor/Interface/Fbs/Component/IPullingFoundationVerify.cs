using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB7 RID: 23991
	public static class IPullingFoundationVerify
	{
		// Token: 0x06027FF5 RID: 163829 RVA: 0x005788D0 File Offset: 0x00576AD0
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

		// Token: 0x0200845B RID: 33883
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014756 RID: 83798
			public static VerifyTableAction <0>__Verify;
		}
	}
}
