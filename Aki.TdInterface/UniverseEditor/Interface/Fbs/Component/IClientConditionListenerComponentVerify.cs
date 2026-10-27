using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA8 RID: 20392
	public static class IClientConditionListenerComponentVerify
	{
		// Token: 0x06020724 RID: 132900 RVA: 0x004838E4 File Offset: 0x00481AE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientConditionListenerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientConditionListenerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IClientConditionListenerVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AB1 RID: 31409
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401349E RID: 79006
			public static VerifyTableAction <0>__Verify;
		}
	}
}
