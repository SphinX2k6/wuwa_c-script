using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200475F RID: 18271
	public static class IGlobalFixActionsVerify
	{
		// Token: 0x0601C20C RID: 115212 RVA: 0x003FC325 File Offset: 0x003FA525
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGlobalFixActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGlobalFixActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079EC RID: 31212
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013399 RID: 78745
			public static VerifyTableAction <0>__Verify;
		}
	}
}
