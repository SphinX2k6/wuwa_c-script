using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007752 RID: 30546
	public static class IServerForceEnableLevelPlayVerify
	{
		// Token: 0x060359BF RID: 219583 RVA: 0x0072F791 File Offset: 0x0072D991
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IServerForceEnableLevelPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IServerForceEnableLevelPlayVerify.<>O.<0>__Verify = new VerifyTableAction(IEnableLevelPlayConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086BF RID: 34495
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB8 RID: 84664
			public static VerifyTableAction <0>__Verify;
		}
	}
}
