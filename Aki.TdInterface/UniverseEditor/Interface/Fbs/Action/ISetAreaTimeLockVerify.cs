using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007770 RID: 30576
	public static class ISetAreaTimeLockVerify
	{
		// Token: 0x06035AAA RID: 219818 RVA: 0x00731168 File Offset: 0x0072F368
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetAreaTimeLockVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAreaTimeLockVerify.<>O.<0>__Verify = new VerifyTableAction(IFixedTimeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086C2 RID: 34498
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ABC RID: 84668
			public static VerifyTableAction <0>__Verify;
		}
	}
}
