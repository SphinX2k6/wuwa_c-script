using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004354 RID: 17236
	public static class ILogicProgramSpecialProcessVerify
	{
		// Token: 0x06018531 RID: 99633 RVA: 0x00378439 File Offset: 0x00376639
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILogicProgramSpecialProcessVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILogicProgramSpecialProcessVerify.<>O.<0>__Verify = new VerifyTableAction(IDisableUroVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200814D RID: 33101
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014239 RID: 82489
			public static VerifyTableAction <0>__Verify;
		}
	}
}
