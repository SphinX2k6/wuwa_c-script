using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005364 RID: 21348
	public static class IHeadInfoChangeDataVerify
	{
		// Token: 0x06022EE7 RID: 143079 RVA: 0x004D66DC File Offset: 0x004D48DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHeadInfoChangeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHeadInfoChangeDataVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B52 RID: 31570
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135A1 RID: 79265
			public static VerifyTableAction <0>__Verify;
		}
	}
}
