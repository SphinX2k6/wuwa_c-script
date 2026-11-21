using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF1 RID: 16369
	public static class IActorCollisionTriggerShapeVerify
	{
		// Token: 0x06016642 RID: 91714 RVA: 0x00334DFC File Offset: 0x00332FFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorCollisionTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorCollisionTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080D9 RID: 32985
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401415F RID: 82271
			public static VerifyTableAction <0>__Verify;
		}
	}
}
