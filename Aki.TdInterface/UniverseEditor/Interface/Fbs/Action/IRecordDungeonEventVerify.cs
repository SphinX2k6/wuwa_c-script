using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E12 RID: 28178
	public static class IRecordDungeonEventVerify
	{
		// Token: 0x06031C97 RID: 203927 RVA: 0x006BD9D1 File Offset: 0x006BBBD1
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

		// Token: 0x02007E0A RID: 32266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C5 RID: 80325
			public static VerifyTableAction <0>__Verify;
		}
	}
}
