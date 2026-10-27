using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B67 RID: 23399
	public static class IWaySplineStartPointVerify
	{
		// Token: 0x060280A2 RID: 164002 RVA: 0x005813D8 File Offset: 0x0057F5D8
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

		// Token: 0x02007C7C RID: 31868
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137A2 RID: 79778
			public static VerifyTableAction <0>__Verify;
		}
	}
}
