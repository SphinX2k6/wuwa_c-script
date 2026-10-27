using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B86 RID: 15238
	public static class ISyncBlockGroupVerify
	{
		// Token: 0x06014E14 RID: 85524 RVA: 0x00307D38 File Offset: 0x00305F38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISyncBlockGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISyncBlockGroupVerify.<>O.<0>__Verify = new VerifyTableAction(ISyncBlockVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200788C RID: 30860
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F5 RID: 78069
			public static VerifyTableAction <0>__Verify;
		}
	}
}
