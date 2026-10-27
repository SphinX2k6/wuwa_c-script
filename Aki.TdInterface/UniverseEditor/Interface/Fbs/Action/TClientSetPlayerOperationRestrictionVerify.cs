using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767F RID: 30335
	public static class TClientSetPlayerOperationRestrictionVerify
	{
		// Token: 0x06037333 RID: 226099 RVA: 0x0077B5A4 File Offset: 0x007797A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
