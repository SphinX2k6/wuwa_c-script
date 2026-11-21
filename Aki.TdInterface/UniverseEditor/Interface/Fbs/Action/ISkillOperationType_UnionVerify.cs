using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007901 RID: 30977
	public static class ISkillOperationType_UnionVerify
	{
		// Token: 0x060368B6 RID: 223414 RVA: 0x0074D20C File Offset: 0x0074B40C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISkillOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableSkillOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableSkillOperationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDisableSectionalSkillOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
