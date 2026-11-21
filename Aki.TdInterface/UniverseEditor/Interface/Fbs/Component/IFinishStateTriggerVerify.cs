using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BF RID: 22463
	public static class IFinishStateTriggerVerify
	{
		// Token: 0x06024434 RID: 148532 RVA: 0x004FBD30 File Offset: 0x004F9F30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishStateTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishStateTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityGroupConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200837A RID: 33658
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145D6 RID: 83414
			public static VerifyTableAction <0>__Verify;
		}
	}
}
