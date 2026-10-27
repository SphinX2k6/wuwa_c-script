using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006235 RID: 25141
	public static class IBubbleRangeCylinderConfigVerify
	{
		// Token: 0x0602B56F RID: 177519 RVA: 0x005F7A64 File Offset: 0x005F5C64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleCylinderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleCylinderConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CF9 RID: 31993
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013858 RID: 79960
			public static VerifyTableAction <0>__Verify;
		}
	}
}
