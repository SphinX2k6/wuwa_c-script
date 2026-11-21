using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B7 RID: 22199
	public static class IEntityAttachPointVerify
	{
		// Token: 0x060238F9 RID: 145657 RVA: 0x004E3DC0 File Offset: 0x004E1FC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityAttachPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityAttachPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200834C RID: 33612
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401458F RID: 83343
			public static VerifyTableAction <0>__Verify;
		}
	}
}
