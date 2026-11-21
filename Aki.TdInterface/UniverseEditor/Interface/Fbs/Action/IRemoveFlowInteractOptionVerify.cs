using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CF RID: 30159
	public static class IRemoveFlowInteractOptionVerify
	{
		// Token: 0x06034E8F RID: 216719 RVA: 0x0071C388 File Offset: 0x0071A588
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRemoveFlowInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemoveFlowInteractOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008699 RID: 34457
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A8C RID: 84620
			public static VerifyTableAction <0>__Verify;
		}
	}
}
