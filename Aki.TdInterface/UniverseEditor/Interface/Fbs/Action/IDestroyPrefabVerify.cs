using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFE RID: 27646
	public static class IDestroyPrefabVerify
	{
		// Token: 0x0602F94C RID: 194892 RVA: 0x0067C2F0 File Offset: 0x0067A4F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDestroyPrefabVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestroyPrefabVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085B4 RID: 34228
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401495D RID: 84317
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
