using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006459 RID: 25689
	public static class IColorMapDataVerify
	{
		// Token: 0x0602C74C RID: 182092 RVA: 0x00618E74 File Offset: 0x00617074
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IColorMapDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IColorMapDataVerify.<>O.<0>__Verify = new VerifyTableAction(IColorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D2B RID: 32043
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013899 RID: 80025
			public static VerifyTableAction <0>__Verify;
		}
	}
}
