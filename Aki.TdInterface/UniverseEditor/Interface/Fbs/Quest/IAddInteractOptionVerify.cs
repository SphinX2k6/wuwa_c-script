using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF4 RID: 15604
	public static class IAddInteractOptionVerify
	{
		// Token: 0x060157EC RID: 88044 RVA: 0x0031ADFC File Offset: 0x00318FFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddInteractOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractOptionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078AB RID: 30891
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401311D RID: 78109
			public static VerifyTableAction <0>__Verify;
		}
	}
}
