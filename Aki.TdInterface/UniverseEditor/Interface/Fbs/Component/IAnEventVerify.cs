using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E9D RID: 20125
	public static class IAnEventVerify
	{
		// Token: 0x0601FAC9 RID: 129737 RVA: 0x004690E4 File Offset: 0x004672E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAnEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAnEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A7C RID: 31356
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401344C RID: 78924
			public static VerifyTableAction <0>__Verify;
		}
	}
}
