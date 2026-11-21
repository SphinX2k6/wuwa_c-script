using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EDF RID: 24287
	public static class ISceneItemSeqEventCbTypeVerify
	{
		// Token: 0x06028B7D RID: 166781 RVA: 0x00590CB8 File Offset: 0x0058EEB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemSeqEventCbTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemSeqEventCbTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008490 RID: 33936
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147A5 RID: 83877
			public static VerifyTableAction <0>__Verify;
		}
	}
}
