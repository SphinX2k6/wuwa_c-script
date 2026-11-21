using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008032 RID: 32818
	public static class TUiOperationVerify
	{
		// Token: 0x0603B0D6 RID: 241878 RVA: 0x007ED840 File Offset: 0x007EBA40
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
