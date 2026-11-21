using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E6 RID: 22502
	public static class IFlowComponentVerify
	{
		// Token: 0x060245AC RID: 148908 RVA: 0x004FEACC File Offset: 0x004FCCCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008381 RID: 33665
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145DF RID: 83423
			public static VerifyTableAction <0>__Verify;
		}
	}
}
