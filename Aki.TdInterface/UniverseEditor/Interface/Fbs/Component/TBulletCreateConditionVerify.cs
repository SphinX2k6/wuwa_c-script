using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200620C RID: 25100
	public static class TBulletCreateConditionVerify
	{
		// Token: 0x0602AB2C RID: 174892 RVA: 0x005D2394 File Offset: 0x005D0594
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOnCollisionConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOnHitConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOnMatchingConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IOnOpenGravityCollisionConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IOnThrowTriggerTimeConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
