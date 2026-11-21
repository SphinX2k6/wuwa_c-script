using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB6 RID: 20150
	public static class ICheckEnterTriggerDirType_UnionVerify
	{
		// Token: 0x0601F3CA RID: 127946 RVA: 0x0045A9DC File Offset: 0x00458BDC
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
