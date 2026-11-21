using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EDA RID: 20186
	public static class ICheckEntitySelfDirectionVerify
	{
		// Token: 0x0601F567 RID: 128359 RVA: 0x0045DEC0 File Offset: 0x0045C0C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEntitySelfDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntitySelfDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200827D RID: 33405
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401445F RID: 83039
			public static VerifyTableAction <0>__Verify;
		}
	}
}
