using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBD RID: 27581
	public static class INpcGroupPerformInitiatorType_UnionVerify
	{
		// Token: 0x06030736 RID: 198454 RVA: 0x0069456C File Offset: 0x0069276C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerInitiatorVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INpcGroupPerformInitiatorTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
