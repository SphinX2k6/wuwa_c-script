using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB5 RID: 20149
	public static class IAnsEventVerify
	{
		// Token: 0x0601FBB5 RID: 129973 RVA: 0x0046AE30 File Offset: 0x00469030
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAnsEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAnsEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A81 RID: 31361
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013452 RID: 78930
			public static VerifyTableAction <0>__Verify;
		}
	}
}
