using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E4F RID: 20047
	public static class IActivateSpecifiedPieceConfigVerify
	{
		// Token: 0x0601F771 RID: 128881 RVA: 0x0046223C File Offset: 0x0046043C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActivateSpecifiedPieceConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActivateSpecifiedPieceConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A6E RID: 31342
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401343A RID: 78906
			public static VerifyTableAction <0>__Verify;
		}
	}
}
