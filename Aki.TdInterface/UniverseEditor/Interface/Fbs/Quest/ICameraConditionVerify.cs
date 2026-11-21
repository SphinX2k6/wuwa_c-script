using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004159 RID: 16729
	public static class ICameraConditionVerify
	{
		// Token: 0x06016FFC RID: 94204 RVA: 0x00347B44 File Offset: 0x00345D44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080F8 RID: 33016
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014188 RID: 82312
			public static VerifyTableAction <0>__Verify;
		}
	}
}
