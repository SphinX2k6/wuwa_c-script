using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D53 RID: 19795
	public static class TPlayerAttributeVerify
	{
		// Token: 0x0601F693 RID: 128659 RVA: 0x00460648 File Offset: 0x0045E848
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IStabilityPointAttributeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IHealthAttributeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
