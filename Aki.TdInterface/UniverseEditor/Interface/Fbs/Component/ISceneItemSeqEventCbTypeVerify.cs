using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D2 RID: 22738
	public static class ISceneItemSeqEventCbTypeVerify
	{
		// Token: 0x0602661B RID: 157211 RVA: 0x0054A16C File Offset: 0x0054836C
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

		// Token: 0x02007C21 RID: 31777
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013703 RID: 79619
			public static VerifyTableAction <0>__Verify;
		}
	}
}
