using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A70 RID: 27248
	public static class IClientSetSeasonStateVerify
	{
		// Token: 0x0602EC0A RID: 191498 RVA: 0x0065F350 File Offset: 0x0065D550
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientSetSeasonStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientSetSeasonStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientSetSeasonStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008599 RID: 34201
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401493A RID: 84282
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
