using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F3F RID: 20287
	public static class IBulletCreateCondition_UnionVerify
	{
		// Token: 0x060201E2 RID: 131554 RVA: 0x00477D78 File Offset: 0x00475F78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBulletCreateConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOnHitConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOnCollisionConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IOnMatchingConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IOnOpenGravityCollisionConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
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
