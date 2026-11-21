using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DB RID: 22747
	public static class IGroupFinishDestroyVerify
	{
		// Token: 0x06024F0F RID: 151311 RVA: 0x00512598 File Offset: 0x00510798
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

		// Token: 0x020083AE RID: 33710
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014622 RID: 83490
			public static VerifyTableAction <0>__Verify;
		}
	}
}
