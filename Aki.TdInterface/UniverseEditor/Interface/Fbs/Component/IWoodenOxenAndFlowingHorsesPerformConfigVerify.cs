using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B91 RID: 23441
	public static class IWoodenOxenAndFlowingHorsesPerformConfigVerify
	{
		// Token: 0x06028224 RID: 164388 RVA: 0x005842C0 File Offset: 0x005824C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWoodenOxenAndFlowingHorsesPerformConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWoodenOxenAndFlowingHorsesPerformConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWoodenOxenAndFlowingHorsesPerformConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWoodenOxenAndFlowingHorsesPerformConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C83 RID: 31875
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137AD RID: 79789
			public static VerifyTableAction <0>__Verify;
		}
	}
}
