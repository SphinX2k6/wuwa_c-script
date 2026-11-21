using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005669 RID: 22121
	public static class IDynamicTeleportComponentVerify
	{
		// Token: 0x060235F7 RID: 144887 RVA: 0x004DDCEC File Offset: 0x004DBEEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicTeleportComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicTeleportComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008343 RID: 33603
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014580 RID: 83328
			public static VerifyTableAction <0>__Verify;
		}
	}
}
