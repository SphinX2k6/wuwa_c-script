using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F7 RID: 24823
	public static class IActorRefWithMaterialParamVerify
	{
		// Token: 0x0602A689 RID: 173705 RVA: 0x005D7CD8 File Offset: 0x005D5ED8
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

		// Token: 0x02007CD7 RID: 31959
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401380B RID: 79883
			public static VerifyTableAction <0>__Verify;
		}
	}
}
