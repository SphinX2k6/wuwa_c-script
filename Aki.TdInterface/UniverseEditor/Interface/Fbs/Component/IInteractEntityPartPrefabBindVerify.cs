using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005451 RID: 21585
	public static class IInteractEntityPartPrefabBindVerify
	{
		// Token: 0x0602380E RID: 145422 RVA: 0x004E996C File Offset: 0x004E7B6C
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

		// Token: 0x02007B6D RID: 31597
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135DC RID: 79324
			public static VerifyTableAction <0>__Verify;
		}
	}
}
