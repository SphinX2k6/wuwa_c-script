using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F2D RID: 20269
	public static class IBuffAreaStateConfigVerify
	{
		// Token: 0x0602013F RID: 131391 RVA: 0x0047695C File Offset: 0x00474B5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfData(tablePos, 6, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBuffAreaStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffAreaStateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A94 RID: 31380
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013474 RID: 78964
			public static VerifyTableAction <0>__Verify;
		}
	}
}
