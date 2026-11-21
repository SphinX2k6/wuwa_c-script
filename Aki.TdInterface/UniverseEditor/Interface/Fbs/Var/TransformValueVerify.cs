using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F5D RID: 16221
	public static class TransformValueVerify
	{
		// Token: 0x06016116 RID: 90390 RVA: 0x0032AEF5 File Offset: 0x003290F5
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

		// Token: 0x020080CB RID: 32971
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401414C RID: 82252
			public static VerifyTableAction <0>__Verify;
		}
	}
}
