using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560A RID: 22026
	public static class INoiseRemovalNodeVerify
	{
		// Token: 0x060248E0 RID: 149728 RVA: 0x0050B660 File Offset: 0x00509860
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INoiseRemovalNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INoiseRemovalNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BA5 RID: 31653
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401363C RID: 79420
			public static VerifyTableAction <0>__Verify;
		}
	}
}
