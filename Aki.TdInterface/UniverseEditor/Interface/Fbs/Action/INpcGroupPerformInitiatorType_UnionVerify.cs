using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007309 RID: 29449
	public static class INpcGroupPerformInitiatorType_UnionVerify
	{
		// Token: 0x060335B0 RID: 210352 RVA: 0x006ECF0C File Offset: 0x006EB10C
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
