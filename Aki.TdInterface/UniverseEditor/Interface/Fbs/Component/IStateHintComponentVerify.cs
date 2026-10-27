using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AC RID: 22956
	public static class IStateHintComponentVerify
	{
		// Token: 0x06026E49 RID: 159305 RVA: 0x0055A0A4 File Offset: 0x005582A4
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

		// Token: 0x02007C3C RID: 31804
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401372A RID: 79658
			public static VerifyTableAction <0>__Verify;
		}
	}
}
