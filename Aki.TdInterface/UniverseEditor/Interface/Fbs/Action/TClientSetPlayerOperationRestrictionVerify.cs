using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E8D RID: 32397
	public static class TClientSetPlayerOperationRestrictionVerify
	{
		// Token: 0x0603A7DA RID: 239578 RVA: 0x007DF6EC File Offset: 0x007DD8EC
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
