using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758D RID: 30093
	public static class IRecordDungeonEventVerify
	{
		// Token: 0x06034C93 RID: 216211 RVA: 0x007190B9 File Offset: 0x007172B9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRecordDungeonEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRecordDungeonEventVerify.<>O.<0>__Verify = new VerifyTableAction(IRecordTimeStampTypeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008696 RID: 34454
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A89 RID: 84617
			public static VerifyTableAction <0>__Verify;
		}
	}
}
