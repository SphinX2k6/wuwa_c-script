using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420D RID: 16909
	public static class ITrackReturnDungeonVerify
	{
		// Token: 0x06018FC8 RID: 102344 RVA: 0x00398AA0 File Offset: 0x00396CA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackReturnDungeonVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackReturnDungeonVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007974 RID: 31092
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132EA RID: 78570
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
