using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006972 RID: 26994
	public static class IChangeIconVerify
	{
		// Token: 0x0602E49F RID: 189599 RVA: 0x00652020 File Offset: 0x00650220
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeIconVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeIconVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008580 RID: 34176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401491A RID: 84250
			public static VerifyTableAction <0>__Verify;
		}
	}
}
