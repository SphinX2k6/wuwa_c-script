using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE8 RID: 23272
	public static class IMismatchCastConfigVerify
	{
		// Token: 0x06026387 RID: 156551 RVA: 0x0053CC64 File Offset: 0x0053AE64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMismatchCastConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMismatchCastConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMismatchSequenceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083F1 RID: 33777
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146A6 RID: 83622
			public static VerifyTableAction <0>__Verify;
		}
	}
}
