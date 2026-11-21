using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B89 RID: 27529
	public static class ICustomSkillVerify
	{
		// Token: 0x0602F602 RID: 194050 RVA: 0x00676C90 File Offset: 0x00674E90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICustomSkillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomSkillVerify.<>O.<0>__Verify = new VerifyUnionAction(TCommonTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085AE RID: 34222
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014954 RID: 84308
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
