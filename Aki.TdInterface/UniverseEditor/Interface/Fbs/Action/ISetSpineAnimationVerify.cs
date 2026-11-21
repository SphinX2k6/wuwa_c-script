using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200783E RID: 30782
	public static class ISetSpineAnimationVerify
	{
		// Token: 0x06036226 RID: 221734 RVA: 0x007407FD File Offset: 0x0073E9FD
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

		// Token: 0x020086E5 RID: 34533
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AF8 RID: 84728
			public static VerifyTableAction <0>__Verify;
		}
	}
}
