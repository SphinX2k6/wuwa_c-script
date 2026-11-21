using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005726 RID: 22310
	public static class IEntityTrackControlVerify
	{
		// Token: 0x06023E07 RID: 146951 RVA: 0x004EE97C File Offset: 0x004ECB7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityTrackControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTrackControlVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityTrackControlPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008361 RID: 33633
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145AF RID: 83375
			public static VerifyTableAction <0>__Verify;
		}
	}
}
