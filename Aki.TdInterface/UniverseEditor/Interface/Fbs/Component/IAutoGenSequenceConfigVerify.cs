using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005414 RID: 21524
	public static class IAutoGenSequenceConfigVerify
	{
		// Token: 0x06021AAA RID: 137898 RVA: 0x004A3DC4 File Offset: 0x004A1FC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAutoGenSequenceConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAutoGenSequenceConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayLevelSequenceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082DB RID: 33499
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144CE RID: 83150
			public static VerifyTableAction <0>__Verify;
		}
	}
}
