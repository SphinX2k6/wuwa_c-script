using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC0 RID: 32704
	public static class TSetPlayerOperationRestrictionVerify
	{
		// Token: 0x0603AE64 RID: 241252 RVA: 0x007E9B94 File Offset: 0x007E7D94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
