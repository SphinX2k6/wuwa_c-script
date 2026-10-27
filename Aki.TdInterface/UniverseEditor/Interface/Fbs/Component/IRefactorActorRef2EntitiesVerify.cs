using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005816 RID: 22550
	public static class IRefactorActorRef2EntitiesVerify
	{
		// Token: 0x06025EA6 RID: 155302 RVA: 0x0053A700 File Offset: 0x00538900
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

		// Token: 0x02007C01 RID: 31745
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D2 RID: 79570
			public static VerifyTableAction <0>__Verify;
		}
	}
}
