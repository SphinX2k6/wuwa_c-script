using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EFC RID: 24316
	public static class ILevelRefDataVerify
	{
		// Token: 0x06029C43 RID: 171075 RVA: 0x005BB22C File Offset: 0x005B942C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelRefDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelRefDataVerify.<>O.<0>__Verify = new VerifyTableAction(IStreamingGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CC5 RID: 31941
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F5 RID: 79861
			public static VerifyTableAction <0>__Verify;
		}
	}
}
