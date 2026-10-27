using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EAD RID: 24237
	public static class ICommonBtConditionGroupVerify
	{
		// Token: 0x06029867 RID: 170087 RVA: 0x005B06B4 File Offset: 0x005AE8B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtConditionGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtConditionGroupVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtConditionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CBD RID: 31933
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137ED RID: 79853
			public static VerifyTableAction <0>__Verify;
		}
	}
}
