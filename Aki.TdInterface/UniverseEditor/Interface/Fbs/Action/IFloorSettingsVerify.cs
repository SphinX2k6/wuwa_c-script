using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6B RID: 28267
	public static class IFloorSettingsVerify
	{
		// Token: 0x06030D5A RID: 200026 RVA: 0x006A02FC File Offset: 0x0069E4FC
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

		// Token: 0x020085E9 RID: 34281
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149A1 RID: 84385
			public static VerifyTableAction <0>__Verify;
		}
	}
}
