using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD8 RID: 15832
	public static class IDisableTrackAnimVerify
	{
		// Token: 0x060161BE RID: 90558 RVA: 0x0033210D File Offset: 0x0033030D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDisableTrackAnimVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDisableTrackAnimVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078D2 RID: 30930
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013174 RID: 78196
			public static VerifyTableAction <0>__Verify;
		}
	}
}
