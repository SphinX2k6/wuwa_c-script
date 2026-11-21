using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FCC RID: 32716
	public static class TSkillOperationVerify
	{
		// Token: 0x0603AE98 RID: 241304 RVA: 0x007EA020 File Offset: 0x007E8220
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
