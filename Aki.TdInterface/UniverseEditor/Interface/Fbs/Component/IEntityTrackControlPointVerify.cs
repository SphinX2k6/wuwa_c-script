using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C4 RID: 20932
	public static class IEntityTrackControlPointVerify
	{
		// Token: 0x06021ECB RID: 138955 RVA: 0x004B4CCC File Offset: 0x004B2ECC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityTrackControlPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTrackControlPointVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityTrackControlPointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IEntityTrackControlPointVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B08 RID: 31496
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013532 RID: 79154
			public static VerifyTableAction <0>__Verify;
		}
	}
}
