using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044ED RID: 17645
	public static class ILevelPlayActiveVerify
	{
		// Token: 0x0601A7A2 RID: 108450 RVA: 0x003C8584 File Offset: 0x003C6784
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayActiveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayActiveVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079AF RID: 31151
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013349 RID: 78665
			public static VerifyTableAction <0>__Verify;
		}
	}
}
