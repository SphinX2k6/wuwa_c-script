using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EA RID: 22762
	public static class IHeadInfoChangeDataVerify
	{
		// Token: 0x06024F9B RID: 151451 RVA: 0x005135B0 File Offset: 0x005117B0
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

		// Token: 0x020083B1 RID: 33713
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014626 RID: 83494
			public static VerifyTableAction <0>__Verify;
		}
	}
}
