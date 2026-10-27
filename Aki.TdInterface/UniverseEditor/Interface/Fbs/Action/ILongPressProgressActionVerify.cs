using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A55 RID: 27221
	public static class ILongPressProgressActionVerify
	{
		// Token: 0x0602FA9D RID: 195229 RVA: 0x0067CAA8 File Offset: 0x0067ACA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILongPressProgressActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILongPressProgressActionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D9D RID: 32157
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013935 RID: 80181
			public static VerifyTableAction <0>__Verify;
		}
	}
}
