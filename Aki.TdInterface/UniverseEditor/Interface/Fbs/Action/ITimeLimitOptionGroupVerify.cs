using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC5 RID: 31685
	public static class ITimeLimitOptionGroupVerify
	{
		// Token: 0x060391D1 RID: 233937 RVA: 0x007B7F4D File Offset: 0x007B614D
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

		// Token: 0x0200873C RID: 34620
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CBC RID: 85180
			public static VerifyTableAction <0>__Verify;
		}
	}
}
