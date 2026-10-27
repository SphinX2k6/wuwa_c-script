using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007135 RID: 28981
	public static class ISkillOperationType_UnionVerify
	{
		// Token: 0x06033614 RID: 210452 RVA: 0x006ECC00 File Offset: 0x006EAE00
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
