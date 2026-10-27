using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063ED RID: 25581
	public static class IClientSetPlayerPosVerify
	{
		// Token: 0x0602C41A RID: 181274 RVA: 0x00613154 File Offset: 0x00611354
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientSetPlayerPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientSetPlayerPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientTeleportConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D22 RID: 32034
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401388D RID: 80013
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
