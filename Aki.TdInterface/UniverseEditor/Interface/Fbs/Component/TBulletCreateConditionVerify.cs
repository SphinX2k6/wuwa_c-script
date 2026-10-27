using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF3 RID: 23539
	public static class TBulletCreateConditionVerify
	{
		// Token: 0x0602855A RID: 165210 RVA: 0x0058A7B8 File Offset: 0x005889B8
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
