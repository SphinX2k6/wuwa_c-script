using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D8A RID: 23946
	public static class IProbabilityRefreshGroupVerify
	{
		// Token: 0x06027E0C RID: 163340 RVA: 0x00574638 File Offset: 0x00572838
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProbabilityRefreshGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProbabilityRefreshGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IProbabilityRefreshItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008452 RID: 33874
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014749 RID: 83785
			public static VerifyTableAction <0>__Verify;
		}
	}
}
