using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D7 RID: 22999
	public static class IInteractEntityPartPrefabBindVerify
	{
		// Token: 0x060258C6 RID: 153798 RVA: 0x005269E0 File Offset: 0x00524BE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractEntityPartPrefabBindVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractEntityPartPrefabBindVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractEntityPartPrefabOptionPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083CC RID: 33740
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014662 RID: 83554
			public static VerifyTableAction <0>__Verify;
		}
	}
}
