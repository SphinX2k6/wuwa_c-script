using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C1 RID: 25793
	public static class IConditionsVerify
	{
		// Token: 0x0602CBCD RID: 183245 RVA: 0x006264BC File Offset: 0x006246BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionsVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D34 RID: 32052
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A3 RID: 80035
			public static VerifyTableAction <0>__Verify;
		}
	}
}
