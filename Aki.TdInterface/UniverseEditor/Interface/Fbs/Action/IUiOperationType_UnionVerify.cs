using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AA RID: 29866
	public static class IUiOperationType_UnionVerify
	{
		// Token: 0x060364CD RID: 222413 RVA: 0x00761614 File Offset: 0x0075F814
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
