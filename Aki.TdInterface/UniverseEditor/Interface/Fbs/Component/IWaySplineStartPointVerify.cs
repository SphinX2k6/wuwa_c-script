using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200617D RID: 24957
	public static class IWaySplineStartPointVerify
	{
		// Token: 0x0602A666 RID: 173670 RVA: 0x005C8E68 File Offset: 0x005C7068
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaySplineStartPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaySplineStartPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleGenerationConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084ED RID: 34029
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014848 RID: 84040
			public static VerifyTableAction <0>__Verify;
		}
	}
}
