using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007698 RID: 30360
	public static class IRunActionsVerify
	{
		// Token: 0x06035418 RID: 218136 RVA: 0x007255C9 File Offset: 0x007237C9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086AA RID: 34474
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A9E RID: 84638
			public static VerifyTableAction <0>__Verify;
		}
	}
}
