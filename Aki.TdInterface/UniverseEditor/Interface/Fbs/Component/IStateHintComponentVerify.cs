using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB9 RID: 24505
	public static class IStateHintComponentVerify
	{
		// Token: 0x060293B3 RID: 168883 RVA: 0x005A0D10 File Offset: 0x0059EF10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStateHintComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStateHintComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084AB RID: 33963
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147CC RID: 83916
			public static VerifyTableAction <0>__Verify;
		}
	}
}
