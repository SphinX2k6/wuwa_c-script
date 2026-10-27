using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005792 RID: 22418
	public static class IProceduralVisualBaseVerify
	{
		// Token: 0x0602595A RID: 153946 RVA: 0x0052F0F8 File Offset: 0x0052D2F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProceduralVisualBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProceduralVisualBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BE7 RID: 31719
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136AC RID: 79532
			public static VerifyTableAction <0>__Verify;
		}
	}
}
