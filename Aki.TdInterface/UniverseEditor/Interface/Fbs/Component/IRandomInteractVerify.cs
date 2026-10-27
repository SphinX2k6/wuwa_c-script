using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E9 RID: 22505
	public static class IRandomInteractVerify
	{
		// Token: 0x06025D19 RID: 154905 RVA: 0x005373E8 File Offset: 0x005355E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IRandomInteractOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BF9 RID: 31737
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136C6 RID: 79558
			public static VerifyTableAction <0>__Verify;
		}
	}
}
