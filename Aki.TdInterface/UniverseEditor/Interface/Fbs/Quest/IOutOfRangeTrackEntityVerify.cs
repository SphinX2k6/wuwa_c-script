using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F6A RID: 16234
	public static class IOutOfRangeTrackEntityVerify
	{
		// Token: 0x06017189 RID: 94601 RVA: 0x003540B8 File Offset: 0x003522B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOutOfRangeTrackEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOutOfRangeTrackEntityVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007910 RID: 30992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E6 RID: 78310
			public static VerifyTableAction <0>__Verify;
		}
	}
}
