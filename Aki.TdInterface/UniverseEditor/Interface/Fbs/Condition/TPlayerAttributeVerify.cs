using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200524F RID: 21071
	public static class TPlayerAttributeVerify
	{
		// Token: 0x060212DC RID: 135900 RVA: 0x0049461C File Offset: 0x0049281C
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
