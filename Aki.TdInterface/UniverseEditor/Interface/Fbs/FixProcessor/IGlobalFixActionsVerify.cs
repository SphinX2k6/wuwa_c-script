using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC7 RID: 19399
	public static class IGlobalFixActionsVerify
	{
		// Token: 0x0601D9E1 RID: 121313 RVA: 0x004285C1 File Offset: 0x004267C1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGlobalFixActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGlobalFixActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008235 RID: 33333
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014400 RID: 82944
			public static VerifyTableAction <0>__Verify;
		}
	}
}
