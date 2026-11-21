using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D6 RID: 25046
	public static class IWuWaGoInteractStateActionVerify
	{
		// Token: 0x0602A960 RID: 174432 RVA: 0x005CE888 File Offset: 0x005CCA88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoInteractStateActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoInteractStateActionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084F8 RID: 34040
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014857 RID: 84055
			public static VerifyTableAction <0>__Verify;
		}
	}
}
