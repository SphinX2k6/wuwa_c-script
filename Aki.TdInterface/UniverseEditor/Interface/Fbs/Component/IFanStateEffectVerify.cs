using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200523F RID: 21055
	public static class IFanStateEffectVerify
	{
		// Token: 0x060223EE RID: 140270 RVA: 0x004BFF5C File Offset: 0x004BE15C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFanStateEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFanStateEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IFanEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B1C RID: 31516
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013552 RID: 79186
			public static VerifyTableAction <0>__Verify;
		}
	}
}
