using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006759 RID: 26457
	public static class IActorRefWithMaterialParamVerify
	{
		// Token: 0x0602CD6A RID: 183658 RVA: 0x00621C80 File Offset: 0x0061FE80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorRefWithMaterialParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorRefWithMaterialParamVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008548 RID: 34120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148B1 RID: 84145
			public static VerifyTableAction <0>__Verify;
		}
	}
}
