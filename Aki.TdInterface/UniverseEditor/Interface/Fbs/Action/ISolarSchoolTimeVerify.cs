using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007934 RID: 31028
	public static class ISolarSchoolTimeVerify
	{
		// Token: 0x06036A41 RID: 223809 RVA: 0x0074FBC0 File Offset: 0x0074DDC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISolarSchoolTimeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISolarSchoolTimeVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelDateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086FD RID: 34557
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B1A RID: 84762
			public static VerifyTableAction <0>__Verify;
		}
	}
}
