using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A7 RID: 24999
	public static class IWoodenOxenAndFlowingHorsesPerformConfigVerify
	{
		// Token: 0x0602A7E8 RID: 174056 RVA: 0x005CBD50 File Offset: 0x005C9F50
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

		// Token: 0x020084F4 RID: 34036
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014853 RID: 84051
			public static VerifyTableAction <0>__Verify;
		}
	}
}
