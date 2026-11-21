using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F8E RID: 16270
	public static class ISyncBlockGroupVerify
	{
		// Token: 0x060162DE RID: 90846 RVA: 0x0032E2D0 File Offset: 0x0032C4D0
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

		// Token: 0x020080CF RID: 32975
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014150 RID: 82256
			public static VerifyTableAction <0>__Verify;
		}
	}
}
