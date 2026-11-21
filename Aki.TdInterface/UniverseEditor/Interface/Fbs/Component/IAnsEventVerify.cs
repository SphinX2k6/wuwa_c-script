using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DE RID: 21470
	public static class IAnsEventVerify
	{
		// Token: 0x060218B6 RID: 137398 RVA: 0x004A02AC File Offset: 0x0049E4AC
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

		// Token: 0x020082D5 RID: 33493
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144C5 RID: 83141
			public static VerifyTableAction <0>__Verify;
		}
	}
}
