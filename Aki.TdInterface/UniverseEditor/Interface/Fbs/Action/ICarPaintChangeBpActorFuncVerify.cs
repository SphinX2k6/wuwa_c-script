using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006924 RID: 26916
	public static class ICarPaintChangeBpActorFuncVerify
	{
		// Token: 0x0602E1FF RID: 188927 RVA: 0x0064D720 File Offset: 0x0064B920
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

		// Token: 0x0200857A RID: 34170
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014912 RID: 84242
			public static VerifyTableAction <0>__Verify;
		}
	}
}
