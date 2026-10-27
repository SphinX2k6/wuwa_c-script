using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C12 RID: 15378
	public static class ICylinderTriggerShapeVerify
	{
		// Token: 0x06015322 RID: 86818 RVA: 0x00311EFC File Offset: 0x003100FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICylinderTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICylinderTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200789C RID: 30876
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401310A RID: 78090
			public static VerifyTableAction <0>__Verify;
		}
	}
}
