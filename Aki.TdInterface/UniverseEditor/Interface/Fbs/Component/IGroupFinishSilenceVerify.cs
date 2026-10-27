using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005358 RID: 21336
	public static class IGroupFinishSilenceVerify
	{
		// Token: 0x06022E71 RID: 142961 RVA: 0x004D5950 File Offset: 0x004D3B50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupFinishSilenceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupFinishSilenceVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B50 RID: 31568
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401359E RID: 79262
			public static VerifyTableAction <0>__Verify;
		}
	}
}
