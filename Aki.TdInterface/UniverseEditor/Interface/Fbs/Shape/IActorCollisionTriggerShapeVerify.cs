using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE5 RID: 15333
	public static class IActorCollisionTriggerShapeVerify
	{
		// Token: 0x0601514C RID: 86348 RVA: 0x0030E274 File Offset: 0x0030C474
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

		// Token: 0x02007895 RID: 30869
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013103 RID: 78083
			public static VerifyTableAction <0>__Verify;
		}
	}
}
