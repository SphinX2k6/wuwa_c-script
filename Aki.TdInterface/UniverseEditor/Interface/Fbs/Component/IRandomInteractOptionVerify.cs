using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EC RID: 22508
	public static class IRandomInteractOptionVerify
	{
		// Token: 0x06025D2F RID: 154927 RVA: 0x00537674 File Offset: 0x00535874
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomInteractOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractOptionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BFA RID: 31738
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C7 RID: 79559
			public static VerifyTableAction <0>__Verify;
		}
	}
}
