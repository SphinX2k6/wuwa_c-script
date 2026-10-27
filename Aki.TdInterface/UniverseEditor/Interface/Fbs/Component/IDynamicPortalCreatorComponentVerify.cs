using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F8 RID: 20728
	public static class IDynamicPortalCreatorComponentVerify
	{
		// Token: 0x06021618 RID: 136728 RVA: 0x004A2A08 File Offset: 0x004A0C08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicPortalCreatorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicPortalCreatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicPortalByBulletVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AE6 RID: 31462
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134FC RID: 79100
			public static VerifyTableAction <0>__Verify;
		}
	}
}
