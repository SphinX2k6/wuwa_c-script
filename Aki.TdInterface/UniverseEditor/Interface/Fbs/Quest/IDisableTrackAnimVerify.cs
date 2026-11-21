using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004213 RID: 16915
	public static class IDisableTrackAnimVerify
	{
		// Token: 0x060177DD RID: 96221 RVA: 0x0035AB11 File Offset: 0x00358D11
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

		// Token: 0x02008118 RID: 33048
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141D2 RID: 82386
			public static VerifyTableAction <0>__Verify;
		}
	}
}
