using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6A RID: 27242
	public static class IClientSetPlayerOperationRestriction_UnionVerify
	{
		// Token: 0x0602EBDA RID: 191450 RVA: 0x0065ECE8 File Offset: 0x0065CEE8
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
