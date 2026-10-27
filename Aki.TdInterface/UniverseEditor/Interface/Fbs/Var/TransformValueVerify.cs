using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B55 RID: 15189
	public static class TransformValueVerify
	{
		// Token: 0x06014C4C RID: 85068 RVA: 0x0030495D File Offset: 0x00302B5D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = TransformValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TransformValueVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007888 RID: 30856
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F1 RID: 78065
			public static VerifyTableAction <0>__Verify;
		}
	}
}
