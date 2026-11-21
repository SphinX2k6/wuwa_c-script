using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006538 RID: 25912
	public static class ITagsConfigVerify
	{
		// Token: 0x0602C2B7 RID: 180919 RVA: 0x00603FB5 File Offset: 0x006021B5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITagsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITagsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ITagConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008535 RID: 34101
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401489A RID: 84122
			public static VerifyTableAction <0>__Verify;
		}
	}
}
