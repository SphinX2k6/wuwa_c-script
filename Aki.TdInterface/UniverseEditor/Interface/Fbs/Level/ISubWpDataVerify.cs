using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004417 RID: 17431
	public static class ISubWpDataVerify
	{
		// Token: 0x06019F5F RID: 106335 RVA: 0x003B66D0 File Offset: 0x003B48D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubWpDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubWpDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007997 RID: 31127
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401331A RID: 78618
			public static VerifyTableAction <0>__Verify;
		}
	}
}
