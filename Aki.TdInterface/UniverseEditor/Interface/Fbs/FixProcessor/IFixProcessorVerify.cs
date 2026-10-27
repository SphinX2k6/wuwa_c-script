using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004759 RID: 18265
	public static class IFixProcessorVerify
	{
		// Token: 0x0601C1CE RID: 115150 RVA: 0x003FBAD1 File Offset: 0x003F9CD1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixProcessorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixProcessorVerify.<>O.<0>__Verify = new VerifyTableAction(IFixActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079EA RID: 31210
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013396 RID: 78742
			public static VerifyTableAction <0>__Verify;
		}
	}
}
