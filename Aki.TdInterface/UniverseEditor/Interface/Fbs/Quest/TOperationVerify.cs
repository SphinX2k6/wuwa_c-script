using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200474E RID: 18254
	public static class TOperationVerify
	{
		// Token: 0x0601AE2E RID: 110126 RVA: 0x003D09A0 File Offset: 0x003CEBA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDisableHLODVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAssignLoadingBackgroundVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
