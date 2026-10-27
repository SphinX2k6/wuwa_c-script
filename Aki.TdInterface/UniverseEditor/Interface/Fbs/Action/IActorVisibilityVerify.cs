using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006112 RID: 24850
	public static class IActorVisibilityVerify
	{
		// Token: 0x0602A764 RID: 173924 RVA: 0x005D94DC File Offset: 0x005D76DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorVisibilityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorVisibilityVerify.<>O.<0>__Verify = new VerifyTableAction(IActorVisibilityEffectDefaultVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CDA RID: 31962
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401380E RID: 79886
			public static VerifyTableAction <0>__Verify;
		}
	}
}
