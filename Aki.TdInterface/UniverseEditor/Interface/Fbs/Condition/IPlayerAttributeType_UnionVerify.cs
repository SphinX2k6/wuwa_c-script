using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005183 RID: 20867
	public static class IPlayerAttributeType_UnionVerify
	{
		// Token: 0x06020D5E RID: 134494 RVA: 0x0048B80C File Offset: 0x00489A0C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPlayerAttributeTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHealthAttributeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IStabilityPointAttributeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
