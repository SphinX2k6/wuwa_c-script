using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F6 RID: 18934
	public static class ICheckEnterTriggerDirType_UnionVerify
	{
		// Token: 0x0601D957 RID: 121175 RVA: 0x00429D70 File Offset: 0x00427F70
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckEnterTriggerDirTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckEnterTriggerDirTypeForwardAngleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckEnterTriggerDirTypeVelocityDirAngleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
