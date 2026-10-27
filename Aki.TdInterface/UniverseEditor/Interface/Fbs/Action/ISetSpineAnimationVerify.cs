using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007072 RID: 28786
	public static class ISetSpineAnimationVerify
	{
		// Token: 0x06032F85 RID: 208773 RVA: 0x006E0249 File Offset: 0x006DE449
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetSpineAnimationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSpineAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IPlaySpineAnimationVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E4F RID: 32335
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A24 RID: 80420
			public static VerifyTableAction <0>__Verify;
		}
	}
}
