using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D87 RID: 28039
	public static class IExecClientBattleActionVerify
	{
		// Token: 0x06030640 RID: 198208 RVA: 0x00693718 File Offset: 0x00691918
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExecClientBattleActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecClientBattleActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TExecClientBattleOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085D3 RID: 34259
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014986 RID: 84358
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
