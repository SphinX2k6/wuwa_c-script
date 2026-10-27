using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200510D RID: 20749
	public static class IEffectAreaComponentVerify
	{
		// Token: 0x060216F5 RID: 136949 RVA: 0x004A4640 File Offset: 0x004A2840
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEffectAreaComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEffectAreaComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IBuffAreaVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AEA RID: 31466
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013503 RID: 79107
			public static VerifyTableAction <0>__Verify;
		}
	}
}
