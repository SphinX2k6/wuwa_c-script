using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E17 RID: 28183
	public static class IFadeOutScreenVerify
	{
		// Token: 0x06030A9B RID: 199323 RVA: 0x0069B064 File Offset: 0x00699264
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFadeOutScreenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeOutScreenVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085DF RID: 34271
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014996 RID: 84374
			public static VerifyTableAction <0>__Verify;
		}
	}
}
