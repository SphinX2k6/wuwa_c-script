using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006067 RID: 24679
	public static class IAbsolutePos2Verify
	{
		// Token: 0x06029C8D RID: 171149 RVA: 0x005BBB7C File Offset: 0x005B9D7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAbsolutePos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAbsolutePos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CC8 RID: 31944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F8 RID: 79864
			public static VerifyTableAction <0>__Verify;
		}
	}
}
