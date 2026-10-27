using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D9 RID: 26585
	public static class IFixGetItemVerify
	{
		// Token: 0x0602E481 RID: 189569 RVA: 0x00651D45 File Offset: 0x0064FF45
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixGetItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixGetItemVerify.<>O.<0>__Verify = new VerifyTableAction(IItemDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D71 RID: 32113
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F4 RID: 80116
			public static VerifyTableAction <0>__Verify;
		}
	}
}
