using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A5 RID: 17317
	public static class IOperation_UnionVerify
	{
		// Token: 0x060187C9 RID: 100297 RVA: 0x0037D138 File Offset: 0x0037B338
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableHLODVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAssignLoadingBackgroundVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
