using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007054 RID: 28756
	public static class ISetPlayerOperationRestriction_UnionVerify
	{
		// Token: 0x06032E34 RID: 208436 RVA: 0x006DD0C0 File Offset: 0x006DB2C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetPlayerOperationRestrictionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
