using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005783 RID: 22403
	public static class IProbabilityRefreshGroupVerify
	{
		// Token: 0x060258EC RID: 153836 RVA: 0x0052E4AC File Offset: 0x0052C6AC
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

		// Token: 0x02007BE4 RID: 31716
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136A9 RID: 79529
			public static VerifyTableAction <0>__Verify;
		}
	}
}
