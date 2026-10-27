using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C1 RID: 29377
	public static class ITalkItemAutoPlayConfigVerify
	{
		// Token: 0x060342F5 RID: 213749 RVA: 0x007049A9 File Offset: 0x00702BA9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemAutoPlayConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemAutoPlayConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkItemDisableAutoSelectOptionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E82 RID: 32386
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A76 RID: 80502
			public static VerifyTableAction <0>__Verify;
		}
	}
}
