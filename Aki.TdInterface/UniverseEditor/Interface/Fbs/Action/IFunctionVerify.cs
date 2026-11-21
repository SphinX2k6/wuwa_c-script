using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0A RID: 28426
	public static class IFunctionVerify
	{
		// Token: 0x06031314 RID: 201492 RVA: 0x006AAABC File Offset: 0x006A8CBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFunctionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085F8 RID: 34296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B4 RID: 84404
			public static VerifyTableAction <0>__Verify;
		}
	}
}
