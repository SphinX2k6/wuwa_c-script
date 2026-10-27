using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005355 RID: 21333
	public static class IGroupFinishDestroyVerify
	{
		// Token: 0x06022E5B RID: 142939 RVA: 0x004D56C4 File Offset: 0x004D38C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupFinishDestroyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupFinishDestroyVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B4F RID: 31567
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401359D RID: 79261
			public static VerifyTableAction <0>__Verify;
		}
	}
}
