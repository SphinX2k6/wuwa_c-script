using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C3 RID: 30147
	public static class IRemoveEffectVerify
	{
		// Token: 0x06034E3D RID: 216637 RVA: 0x0071BBB5 File Offset: 0x00719DB5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRemoveEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemoveEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IRemoveScreenEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008698 RID: 34456
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A8B RID: 84619
			public static VerifyTableAction <0>__Verify;
		}
	}
}
