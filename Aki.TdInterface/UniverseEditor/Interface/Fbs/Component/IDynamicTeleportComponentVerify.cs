using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005104 RID: 20740
	public static class IDynamicTeleportComponentVerify
	{
		// Token: 0x060216A3 RID: 136867 RVA: 0x004A3D60 File Offset: 0x004A1F60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicTeleportComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicTeleportComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AE9 RID: 31465
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013502 RID: 79106
			public static VerifyTableAction <0>__Verify;
		}
	}
}
