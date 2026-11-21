using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007758 RID: 30552
	public static class ISetActorVarVerify
	{
		// Token: 0x060359F4 RID: 219636 RVA: 0x0072FF14 File Offset: 0x0072E114
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetActorVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetActorVarVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISetActorVarVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetActorVarVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086C1 RID: 34497
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ABA RID: 84666
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014ABB RID: 84667
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
