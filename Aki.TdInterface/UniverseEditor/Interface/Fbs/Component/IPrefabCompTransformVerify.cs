using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D7E RID: 23934
	public static class IPrefabCompTransformVerify
	{
		// Token: 0x06027DAC RID: 163244 RVA: 0x00573B6C File Offset: 0x00571D6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPrefabCompTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPrefabCompTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IPrefabCompTransformItemVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPrefabCompTransformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPrefabCompTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IPrefabCompTransformItemVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPrefabCompTransformVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IPrefabCompTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IPrefabCompTransformItemVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008450 RID: 33872
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014747 RID: 83783
			public static VerifyTableAction <0>__Verify;
		}
	}
}
