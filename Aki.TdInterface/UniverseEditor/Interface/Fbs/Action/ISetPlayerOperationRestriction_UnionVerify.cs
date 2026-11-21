using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007820 RID: 30752
	public static class ISetPlayerOperationRestriction_UnionVerify
	{
		// Token: 0x060360D1 RID: 221393 RVA: 0x0073D5E8 File Offset: 0x0073B7E8
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
