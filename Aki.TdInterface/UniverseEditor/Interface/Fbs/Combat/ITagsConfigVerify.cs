using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EF5 RID: 24309
	public static class ITagsConfigVerify
	{
		// Token: 0x06029C03 RID: 171011 RVA: 0x005BAAD1 File Offset: 0x005B8CD1
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

		// Token: 0x02007CC4 RID: 31940
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F4 RID: 79860
			public static VerifyTableAction <0>__Verify;
		}
	}
}
