using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EF RID: 17135
	public static class TOperationVerify
	{
		// Token: 0x060196AC RID: 104108 RVA: 0x003A5070 File Offset: 0x003A3270
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
