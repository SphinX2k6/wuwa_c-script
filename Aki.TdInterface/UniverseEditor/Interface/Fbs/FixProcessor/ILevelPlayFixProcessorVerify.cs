using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004765 RID: 18277
	public static class ILevelPlayFixProcessorVerify
	{
		// Token: 0x0601C236 RID: 115254 RVA: 0x003FC7B9 File Offset: 0x003FA9B9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayFixProcessorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayFixProcessorVerify.<>O.<0>__Verify = new VerifyTableAction(IFixActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079ED RID: 31213
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401339A RID: 78746
			public static VerifyTableAction <0>__Verify;
		}
	}
}
