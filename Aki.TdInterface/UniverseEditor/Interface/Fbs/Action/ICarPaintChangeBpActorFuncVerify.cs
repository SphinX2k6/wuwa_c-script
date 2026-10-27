using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B3 RID: 25267
	public static class ICarPaintChangeBpActorFuncVerify
	{
		// Token: 0x0602BA9E RID: 178846 RVA: 0x00602918 File Offset: 0x00600B18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICarPaintChangeBpActorFuncVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICarPaintChangeBpActorFuncVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D07 RID: 32007
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401386A RID: 79978
			public static VerifyTableAction <0>__Verify;
		}
	}
}
