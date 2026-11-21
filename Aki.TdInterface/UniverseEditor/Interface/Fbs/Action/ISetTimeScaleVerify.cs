using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007865 RID: 30821
	public static class ISetTimeScaleVerify
	{
		// Token: 0x0603634F RID: 222031 RVA: 0x00742DA9 File Offset: 0x00740FA9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetTimeScaleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetTimeScaleVerify.<>O.<0>__Verify = new VerifyTableAction(ISetGlobalTimeScaleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086EC RID: 34540
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B01 RID: 84737
			public static VerifyTableAction <0>__Verify;
		}
	}
}
