using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DB RID: 29659
	public static class ITimeLimitOptionGroupVerify
	{
		// Token: 0x06035E1E RID: 220702 RVA: 0x007557D9 File Offset: 0x007539D9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeLimitOptionGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeLimitOptionGroupVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeLimitOptionGroupDefaultVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EA3 RID: 32419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BE3 RID: 80867
			public static VerifyTableAction <0>__Verify;
		}
	}
}
