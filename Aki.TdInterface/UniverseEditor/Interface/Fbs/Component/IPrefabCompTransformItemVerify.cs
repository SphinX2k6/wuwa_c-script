using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D81 RID: 23937
	public static class IPrefabCompTransformItemVerify
	{
		// Token: 0x06027DC2 RID: 163266 RVA: 0x00573E48 File Offset: 0x00572048
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPrefabCompTransformItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPrefabCompTransformItemVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008451 RID: 33873
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014748 RID: 83784
			public static VerifyTableAction <0>__Verify;
		}
	}
}
