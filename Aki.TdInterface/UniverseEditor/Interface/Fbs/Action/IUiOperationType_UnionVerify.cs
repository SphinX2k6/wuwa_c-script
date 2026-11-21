using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA0 RID: 31904
	public static class IUiOperationType_UnionVerify
	{
		// Token: 0x060398D6 RID: 235734 RVA: 0x007C46A0 File Offset: 0x007C28A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUiOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableUiOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableUiOperationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEnableSectionalUiVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
