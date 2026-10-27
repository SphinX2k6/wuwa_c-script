using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007129 RID: 28969
	public static class ISkillBlackboardVectorVerify
	{
		// Token: 0x060335D4 RID: 210388 RVA: 0x006EC690 File Offset: 0x006EA890
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISkillBlackboardVectorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkillBlackboardVectorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E63 RID: 32355
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A40 RID: 80448
			public static VerifyTableAction <0>__Verify;
		}
	}
}
