using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E0 RID: 22496
	public static class IFixedStreamingSourceVerify
	{
		// Token: 0x0602457C RID: 148860 RVA: 0x004FE5C0 File Offset: 0x004FC7C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedStreamingSourceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedStreamingSourceVerify.<>O.<0>__Verify = new VerifyTableAction(IStreamingSourceConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008380 RID: 33664
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145DE RID: 83422
			public static VerifyTableAction <0>__Verify;
		}
	}
}
