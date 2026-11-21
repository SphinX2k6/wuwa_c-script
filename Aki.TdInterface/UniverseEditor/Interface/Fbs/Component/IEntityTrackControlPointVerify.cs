using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005729 RID: 22313
	public static class IEntityTrackControlPointVerify
	{
		// Token: 0x06023E23 RID: 146979 RVA: 0x004EED34 File Offset: 0x004ECF34
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

		// Token: 0x02008362 RID: 33634
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B0 RID: 83376
			public static VerifyTableAction <0>__Verify;
		}
	}
}
