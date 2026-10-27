using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007794 RID: 30612
	public static class TSkillOperationVerify
	{
		// Token: 0x0603791D RID: 227613 RVA: 0x00784B20 File Offset: 0x00782D20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableSectionalSkillOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableSkillOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableSkillOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
