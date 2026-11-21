using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE8 RID: 19176
	public static class IPlayFlowForGmVerify
	{
		// Token: 0x0601CE41 RID: 118337 RVA: 0x00411070 File Offset: 0x0040F270
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayFlowForGmVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayFlowForGmVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008218 RID: 33304
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D2 RID: 82898
			public static VerifyTableAction <0>__Verify;
		}
	}
}
