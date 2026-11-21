using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E2 RID: 25058
	public static class IWuWaGoMovableGridStatePosVerify
	{
		// Token: 0x0602A9E8 RID: 174568 RVA: 0x005CFAA0 File Offset: 0x005CDCA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoMovableGridStatePosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoMovableGridStatePosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084FB RID: 34043
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401485B RID: 84059
			public static VerifyTableAction <0>__Verify;
		}
	}
}
