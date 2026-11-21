using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C4 RID: 17092
	public static class IHandInGroupVerify
	{
		// Token: 0x06017F70 RID: 98160 RVA: 0x0036BE00 File Offset: 0x0036A000
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHandInGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandInGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IHandInItemRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008138 RID: 33080
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401420A RID: 82442
			public static VerifyTableAction <0>__Verify;
		}
	}
}
