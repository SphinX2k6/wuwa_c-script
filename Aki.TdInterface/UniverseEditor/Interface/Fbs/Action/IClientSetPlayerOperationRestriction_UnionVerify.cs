using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063EA RID: 25578
	public static class IClientSetPlayerOperationRestriction_UnionVerify
	{
		// Token: 0x0602C404 RID: 181252 RVA: 0x00612E5C File Offset: 0x0061105C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientSetPlayerOperationRestrictionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IClientDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
