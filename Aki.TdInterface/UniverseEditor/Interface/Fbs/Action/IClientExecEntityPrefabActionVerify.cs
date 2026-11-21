using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A31 RID: 27185
	public static class IClientExecEntityPrefabActionVerify
	{
		// Token: 0x0602EA22 RID: 191010 RVA: 0x0065BABD File Offset: 0x00659CBD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientExecEntityPrefabActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientExecEntityPrefabActionVerify.<>O.<0>__Verify = new VerifyTableAction(IClientModifyEntityPrefabParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008592 RID: 34194
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014933 RID: 84275
			public static VerifyTableAction <0>__Verify;
		}
	}
}
