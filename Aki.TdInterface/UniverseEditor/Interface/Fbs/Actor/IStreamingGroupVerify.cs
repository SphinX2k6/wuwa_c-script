using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005F02 RID: 24322
	public static class IStreamingGroupVerify
	{
		// Token: 0x06029C77 RID: 171127 RVA: 0x005BB8F0 File Offset: 0x005B9AF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStreamingGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStreamingGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CC7 RID: 31943
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F7 RID: 79863
			public static VerifyTableAction <0>__Verify;
		}
	}
}
