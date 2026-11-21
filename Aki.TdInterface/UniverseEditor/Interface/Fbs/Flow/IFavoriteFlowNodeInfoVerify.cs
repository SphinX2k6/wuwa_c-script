using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA0 RID: 19360
	public static class IFavoriteFlowNodeInfoVerify
	{
		// Token: 0x0601D873 RID: 120947 RVA: 0x00425434 File Offset: 0x00423634
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

		// Token: 0x0200822B RID: 33323
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F1 RID: 82929
			public static VerifyTableAction <0>__Verify;
		}
	}
}
