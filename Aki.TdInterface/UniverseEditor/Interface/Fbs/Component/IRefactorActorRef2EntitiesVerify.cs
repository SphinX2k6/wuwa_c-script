using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E1D RID: 24093
	public static class IRefactorActorRef2EntitiesVerify
	{
		// Token: 0x060283C6 RID: 164806 RVA: 0x0058088C File Offset: 0x0057EA8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRefactorActorRef2EntitiesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRefactorActorRef2EntitiesVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200846F RID: 33903
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014772 RID: 83826
			public static VerifyTableAction <0>__Verify;
		}
	}
}
