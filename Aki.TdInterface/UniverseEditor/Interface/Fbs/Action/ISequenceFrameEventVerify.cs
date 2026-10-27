using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F83 RID: 28547
	public static class ISequenceFrameEventVerify
	{
		// Token: 0x06032701 RID: 206593 RVA: 0x006CED24 File Offset: 0x006CCF24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceFrameEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceFrameEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E28 RID: 32296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E5 RID: 80357
			public static VerifyTableAction <0>__Verify;
		}
	}
}
