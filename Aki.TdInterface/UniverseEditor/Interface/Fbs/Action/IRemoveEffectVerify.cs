using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E45 RID: 28229
	public static class IRemoveEffectVerify
	{
		// Token: 0x06031E27 RID: 204327 RVA: 0x006C022D File Offset: 0x006BE42D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRemoveEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemoveEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IRemoveScreenEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E0C RID: 32268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C7 RID: 80327
			public static VerifyTableAction <0>__Verify;
		}
	}
}
