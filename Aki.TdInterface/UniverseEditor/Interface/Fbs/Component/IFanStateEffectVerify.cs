using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A7 RID: 22439
	public static class IFanStateEffectVerify
	{
		// Token: 0x06024384 RID: 148356 RVA: 0x004FAA20 File Offset: 0x004F8C20
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

		// Token: 0x02008377 RID: 33655
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145D2 RID: 83410
			public static VerifyTableAction <0>__Verify;
		}
	}
}
