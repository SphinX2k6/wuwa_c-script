using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577A RID: 22394
	public static class IPrefabCompTransformItemVerify
	{
		// Token: 0x060258A2 RID: 153762 RVA: 0x0052DCBC File Offset: 0x0052BEBC
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

		// Token: 0x02007BE3 RID: 31715
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136A8 RID: 79528
			public static VerifyTableAction <0>__Verify;
		}
	}
}
