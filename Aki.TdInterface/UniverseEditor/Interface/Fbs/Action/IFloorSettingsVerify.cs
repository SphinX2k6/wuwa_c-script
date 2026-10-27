using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EB RID: 26603
	public static class IFloorSettingsVerify
	{
		// Token: 0x0602E514 RID: 189716 RVA: 0x00652BB8 File Offset: 0x00650DB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFloorSettingsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFloorSettingsVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D72 RID: 32114
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F5 RID: 80117
			public static VerifyTableAction <0>__Verify;
		}
	}
}
