using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006412 RID: 25618
	public static class IGiantStableValueRangeVerify
	{
		// Token: 0x0602B865 RID: 178277 RVA: 0x005ED6E4 File Offset: 0x005EB8E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGiantStableValueRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantStableValueRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantStableValueVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGiantStableValueRangeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IGiantStableValueRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantStableValueVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200851A RID: 34074
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401487C RID: 84092
			public static VerifyTableAction <0>__Verify;
		}
	}
}
