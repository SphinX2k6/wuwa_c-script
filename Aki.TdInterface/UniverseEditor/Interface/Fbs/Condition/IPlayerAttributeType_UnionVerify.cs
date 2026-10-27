using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C8A RID: 19594
	public static class IPlayerAttributeType_UnionVerify
	{
		// Token: 0x0601F13C RID: 127292 RVA: 0x00457CBC File Offset: 0x00455EBC
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
