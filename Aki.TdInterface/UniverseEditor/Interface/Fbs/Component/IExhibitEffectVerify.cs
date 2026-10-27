using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D3 RID: 20947
	public static class IExhibitEffectVerify
	{
		// Token: 0x06021F83 RID: 139139 RVA: 0x004B661C File Offset: 0x004B481C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExhibitEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExhibitEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B0D RID: 31501
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013537 RID: 79159
			public static VerifyTableAction <0>__Verify;
		}
	}
}
