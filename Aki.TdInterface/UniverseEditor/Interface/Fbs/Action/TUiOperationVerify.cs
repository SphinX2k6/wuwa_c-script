using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F4 RID: 30708
	public static class TUiOperationVerify
	{
		// Token: 0x06037B31 RID: 228145 RVA: 0x00787EC8 File Offset: 0x007860C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableUiOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableSectionalUiVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableUiOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
