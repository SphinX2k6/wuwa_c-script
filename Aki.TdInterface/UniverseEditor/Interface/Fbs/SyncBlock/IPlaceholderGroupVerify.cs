using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B7D RID: 15229
	public static class IPlaceholderGroupVerify
	{
		// Token: 0x06014DBE RID: 85438 RVA: 0x003073F4 File Offset: 0x003055F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlaceholderGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlaceholderGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IPlaceholderVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200788B RID: 30859
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F4 RID: 78068
			public static VerifyTableAction <0>__Verify;
		}
	}
}
