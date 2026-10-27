using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004738 RID: 18232
	public static class IFavoriteFlowNodeInfoVerify
	{
		// Token: 0x0601C09E RID: 114846 RVA: 0x003F9198 File Offset: 0x003F7398
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFavoriteFlowNodeInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFavoriteFlowNodeInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowStateIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079E2 RID: 31202
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401338A RID: 78730
			public static VerifyTableAction <0>__Verify;
		}
	}
}
