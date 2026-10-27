using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC2 RID: 27842
	public static class IPhotographConfigVerify
	{
		// Token: 0x06031116 RID: 200982 RVA: 0x006A8BEC File Offset: 0x006A6DEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPhotographPlayerPerformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPhotographConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPhotographConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IPhotographCameraParamsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DEA RID: 32234
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401399C RID: 80284
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401399D RID: 80285
			public static VerifyTableAction <1>__Verify;
		}
	}
}
