using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D99 RID: 23961
	public static class IProceduralVisualBaseVerify
	{
		// Token: 0x06027E7A RID: 163450 RVA: 0x00575284 File Offset: 0x00573484
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

		// Token: 0x02008455 RID: 33877
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401474C RID: 83788
			public static VerifyTableAction <0>__Verify;
		}
	}
}
