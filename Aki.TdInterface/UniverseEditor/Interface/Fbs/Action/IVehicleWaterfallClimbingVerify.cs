using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753D RID: 30013
	public static class IVehicleWaterfallClimbingVerify
	{
		// Token: 0x060369BD RID: 223677 RVA: 0x0076B4AC File Offset: 0x007696AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVehicleWaterfallClimbingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleWaterfallClimbingVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleWaterfallClimbGravityConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EC9 RID: 32457
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C15 RID: 80917
			public static VerifyTableAction <0>__Verify;
		}
	}
}
