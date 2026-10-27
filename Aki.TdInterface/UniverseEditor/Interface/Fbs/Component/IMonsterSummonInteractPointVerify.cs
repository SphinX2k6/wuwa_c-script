using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A4 RID: 21924
	public static class IMonsterSummonInteractPointVerify
	{
		// Token: 0x060244BC RID: 148668 RVA: 0x00502B28 File Offset: 0x00500D28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterSummonInteractPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterSummonInteractPointVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B96 RID: 31638
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013623 RID: 79395
			public static VerifyTableAction <0>__Verify;
		}
	}
}
